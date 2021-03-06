﻿using ICSharpCode.AvalonEdit.Document;
using ICSharpCode.AvalonEdit.Folding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project
{
	public class BraceFoldingStrategy
	{
		public char OpeningBrace { get; set; }

		public char ClosingBrace { get; set; }

		public BraceFoldingStrategy()
		{
			this.OpeningBrace = '{';
			this.ClosingBrace = '}';
		}

		public void UpdateFoldings(FoldingManager manager, TextDocument document)
		{
			int firstErrorOffset;
			IEnumerable<NewFolding> newFoldings = CreateNewFoldings(document, out firstErrorOffset);
			manager.UpdateFoldings(newFoldings, firstErrorOffset);
		}

		public IEnumerable<NewFolding> CreateNewFoldings(TextDocument document, out int firstErrorOffset)
		{
			firstErrorOffset = -1;
			return CreateNewFoldings(document);
		}

		public IEnumerable<NewFolding> CreateNewFoldings(ITextSource document)
		{
			List<NewFolding> newFoldings = new List<NewFolding>();

			Stack<int> startOffsets = new Stack<int>();
			int lastNewLineOffset = 0;
			char openingBrace = this.OpeningBrace;
			char closingBrace = this.ClosingBrace;
			for (int i = 0; i < document.TextLength; i++)
			{
				char c = document.GetCharAt(i);
				if (c == openingBrace)
				{
					startOffsets.Push(i);
				}
				else if (c == closingBrace && startOffsets.Count > 0)
				{
					int startOffset = startOffsets.Pop();
					if (startOffset < lastNewLineOffset)
					{
						newFoldings.Add(new NewFolding(startOffset, i + 1));
					}
				}
				else if (c == '\n' || c == '\r')
				{
					lastNewLineOffset = i + 1;
				}
			}
			newFoldings.Sort((a, b) => a.StartOffset.CompareTo(b.StartOffset));
			return newFoldings;
		}
	}
}
