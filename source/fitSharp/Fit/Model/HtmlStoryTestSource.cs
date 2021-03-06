﻿// Copyright © 2018 Syterra Software Inc. All rights reserved.
// The use and distribution terms for this software are covered by the Common Public License 1.0 (https://opensource.org/licenses/cpl1.0.php)
// which can be found in the file license.txt at the root of this distribution. By using this software in any fashion, you are agreeing
// to be bound by the terms of this license. You must not remove this notice, or any other, from this software.

using fitSharp.Fit.Engine;
using fitSharp.Machine.Application;
using fitSharp.Machine.Model;
using fitSharp.Parser;

namespace fitSharp.Fit.Model {
    public class HtmlStoryTestSource: StoryTestSource {
        public HtmlStoryTestSource(string content) {
            this.content = content;
        }

        public override Tree<Cell> Parse(CellProcessor processor) {
            HtmlString.IsStandard = processor.Get<Settings>().IsStandard;
            return new HtmlTables(text => MakeTreeCell(processor, text)).Parse(content);
        }

        public override string ToString() {
            return content;
        }

        readonly string content;
    }
}
