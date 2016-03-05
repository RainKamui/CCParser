using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CCParser {
	public class CXMLContent {
		public List<CXMLNode> ChildNodes = new List<CXMLNode>();
		public string Text { get; set; }
	}

	public class CXMLNode {
		public string Name { get; set; }
		public Dictionary<string, string> Attribute = new Dictionary<string, string>();
		public CXMLContent Content { get; set; }
	}

	public class CXMLParser {
		private List<string> _strList = new List<string>();
		private int _strMapCounter = 0;
		private char _indentSymbol = ' ';
		private int _indentNum = 4;

		//<(.*?) +([\w\W]*?)>
		private Regex _findNodeRegex = new Regex(@"<(.*?) *?([\w\W]*?)>");
		//(\w+\s*)=\s*(\S+?)[\s\>\?\/]
		private Regex _paserAttibute = new Regex(@"(\S+\s*)=\s*(\S+?)[\s\>\?\/]");
		//<(.*) +([\w\W]*?)>([\w\W]*?)\<\/
		private Regex _getCompleteNode = new Regex(@"<(.*) +([\w\W]*?)>([\w\W]*?)\<\/");
		//##(\d+)##
		private Regex _getIdofString = new Regex(@"##(\d+)##");

		private string getNodeString(string str, string name, int group) {
			return Regex.Match(str, @"<" + name + @"([\w\W]*?)>([\w\W]*?)\<\/" + name + ">").Groups[group].ToString();
		}

		private CXMLNode parseNode(string str) {
			CXMLNode node = new CXMLNode();

			var match = _findNodeRegex.Match(str);
			node.Name = match.Groups[2].ToString();
			if (match.Groups[2].ToString().IndexOf(' ') != -1)
				node.Name = match.Groups[2].ToString().Substring(0, match.Groups[2].ToString().IndexOf(' '));
			var attristr = match.Groups[0].ToString();

			var attrimatch = _paserAttibute.Matches(attristr);
			foreach (Match m in attrimatch) {
				var value = m.Groups[2].ToString();
				var md = _getIdofString.Match(value);
				value = md.Success ? _strList[Convert.ToInt32(md.Groups[1].ToString())] : value;
				var c = m.Groups[1].ToString();
				node.Attribute.Add(m.Groups[1].ToString(), value);
			}

			if (match.Groups[0].ToString().IndexOf(@"/>") == -1) {
				var child = getNodeString(str, node.Name, 2);
				node.Content = getContent(child);
			}
			return node;
		}

		private CXMLContent getContent(string str) {
			var content = new CXMLContent();
			var match = _findNodeRegex.Match(str);
			while (match.Success) {
				var nodehead = match.Groups[0].ToString();
				if (nodehead.IndexOf(@"/>") != -1) {
					content.ChildNodes.Add(parseNode(nodehead));
					str = str.Replace(nodehead, string.Empty);
				}
				else {
					var name = match.Groups[2].ToString();
					if (match.Groups[2].ToString().IndexOf(' ') != -1)
						name = match.Groups[2].ToString().Substring(0, match.Groups[2].ToString().IndexOf(' '));
					var node = getNodeString(str, name, 0);
					content.ChildNodes.Add(parseNode(node));
					str = str.Replace(node, string.Empty);
				}
				match = _findNodeRegex.Match(str);
			}
			var md = _getIdofString.Match(str);

			while (md.Success) {
				str = str.Replace(md.Groups[0].ToString(), _strList[Convert.ToInt32(md.Groups[1].ToString())]);
				md = md.NextMatch();
			}

			if (Regex.Match(str, @"\s+").Groups[0].ToString() == str)
				str = Regex.Replace(str, @"\s+", string.Empty);

			content.Text = str;
			return content;
		}

		private string preProcess(string str) {
			var s = Regex.Replace(str, @"<!--[\w\W]*?-->", string.Empty);
			s = Regex.Replace(s, @"<\?[\w\W]*?\?>", string.Empty);

			var m = Regex.Match(s, @"""([\w\W]*?)""");
			while (m.Success) {
				var tmp = m.Groups[0].Value.ToString();
				_strList.Add(tmp);
				s = s.Replace(tmp, "##" + _strMapCounter + "##");
				_strMapCounter++;
				m = m.NextMatch();
			}

			m = Regex.Match(s, @"<!\[CDATA\[([\w\W]*?)\]\]>");
			while (m.Success) {
				var tmp = m.Groups[0].Value.ToString();
				_strList.Add(tmp);
				s = s.Replace(tmp, "##" + _strMapCounter + "##");
				_strMapCounter++;
				m = m.NextMatch();
			}

			s = Regex.Replace(s, @"<![\w\W]*?>", string.Empty);
			s = Regex.Replace(s, " {2,}", " ");
			return s;
		}

		private string buildXMLString(CXMLNode node, int numOfindent) {
			var str = new string(_indentSymbol, numOfindent) + "<" + node.Name;
			foreach (var item in node.Attribute) {
				str += " " + item.Key + "=" + item.Value;
			}
			if (node.Content == null) {
				str += " />\n";
			}
			else {
				str += ">\n";
				foreach (var child in node.Content.ChildNodes) {
					str += buildXMLString(child, numOfindent + _indentNum);
				}

				if (node.Content.Text != null && node.Content.Text != string.Empty)
					str += new string(_indentSymbol, numOfindent + _indentNum) + node.Content.Text + "\n";
				str += new string(_indentSymbol, numOfindent) + "</" + node.Name + ">\n";
			}
			return str;
		}

		public string BuildXMLDocument(CXMLContent content) {
			var xml = "";
			if (content != null)
				foreach (var node in content.ChildNodes)
					xml += buildXMLString(node, 0);
			return xml;
		}

		public CXMLContent OpenDom(string str) {
			return getContent(preProcess(str));
		}
	}
}
