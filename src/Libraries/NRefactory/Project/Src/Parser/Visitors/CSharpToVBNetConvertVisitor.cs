// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="Daniel Grunwald" email="daniel@danielgrunwald.de"/>
//     <version>$Revision$</version>
// </file>

using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

using ICSharpCode.NRefactory.Parser.VB;
using ICSharpCode.NRefactory.Parser.Ast;

namespace ICSharpCode.NRefactory.Parser
{
	/// <summary>
	/// This class converts C# constructs to their VB.NET equivalents.
	/// </summary>
	public class CSharpToVBNetConvertVisitor : CSharpConstructsVisitor
	{
		public override object Visit(CompilationUnit compilationUnit, object data)
		{
			base.Visit(compilationUnit, data);
			compilationUnit.AcceptVisitor(new ToVBNetConvertVisitor(), data);
			return null;
		}
	}
}
