﻿// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="Mike Krüger" email="mike@icsharpcode.net"/>
//     <version>$Revision$</version>
// </file>

using System;
using System.IO;
using NUnit.Framework;
using ICSharpCode.NRefactory.Parser;
using ICSharpCode.NRefactory.Parser.Ast;

namespace ICSharpCode.NRefactory.Tests.Ast
{
	[TestFixture]
	public class ErrorStatementTests
	{
		#region C#
		// No C# representation
		#endregion
		
		#region VB.NET
		[Test]
		public void VBNetErrorStatementTest()
		{
			ErrorStatement errorStatement = ParseUtilVBNet.ParseStatement<ErrorStatement>("Error a");
		}
		#endregion
	}
}
