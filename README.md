# CompilerCrash

Compile it in Release mode and the csc.exe exits with errorcode -2146232797 in Visual Studio 2017 Enterprise Version 15.6.4

The following stacktrace is found in the eventlog

> Application: csc.exe
Framework Version: v4.0.30319
Description: The application requested process termination through System.Environment.FailFast(string message).
Message: System.IndexOutOfRangeException: Index was outside the bounds of the array.
   at System.Collections.Immutable.ImmutableArray`1.Builder.set_Item(Int32 index, T value)
   at Microsoft.CodeAnalysis.CodeGen.ILBuilder.LocalScopeInfo.GetHoistedLocalScopes(ArrayBuilder`1 result)
   at Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeInfo.GetHoistedLocalScopes[TScopeInfo](ArrayBuilder`1 result, Builder scopes)
   at Microsoft.CodeAnalysis.CodeGen.ILBuilder.LocalScopeInfo.GetHoistedLocalScopes(ArrayBuilder`1 result)
   at Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeInfo.GetHoistedLocalScopes[TScopeInfo](ArrayBuilder`1 result, Builder scopes)
   at Microsoft.CodeAnalysis.CodeGen.ILBuilder.LocalScopeInfo.GetHoistedLocalScopes(ArrayBuilder`1 result)
   at Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeInfo.GetHoistedLocalScopes[TScopeInfo](ArrayBuilder`1 result, Builder scopes)
   at Microsoft.CodeAnalysis.CodeGen.ILBuilder.LocalScopeInfo.GetHoistedLocalScopes(ArrayBuilder`1 result)
   at Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeInfo.GetHoistedLocalScopes[TScopeInfo](ArrayBuilder`1 result, Builder scopes)
   at Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeInfo.GetHoistedLocalScopes[TScopeInfo](ArrayBuilder`1 result, Builder scopes)
   at Microsoft.CodeAnalysis.CodeGen.ILBuilder.LocalScopeInfo.GetHoistedLocalScopes(ArrayBuilder`1 result)
   at Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeInfo.GetHoistedLocalScopes[TScopeInfo](ArrayBuilder`1 result, Builder scopes)
   at Microsoft.CodeAnalysis.CodeGen.ILBuilder.LocalScopeInfo.GetHoistedLocalScopes(ArrayBuilder`1 result)
   at Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeInfo.GetHoistedLocalScopes[TScopeInfo](ArrayBuilder`1 result, Builder scopes)
   at Microsoft.CodeAnalysis.CodeGen.ILBuilder.LocalScopeInfo.GetHoistedLocalScopes(ArrayBuilder`1 result)
   at Microsoft.CodeAnalysis.CodeGen.ILBuilder.LocalScopeManager.GetHoistedLocalScopes()
   at Microsoft.CodeAnalysis.CSharp.MethodCompiler.GenerateMethodBody(PEModuleBuilder moduleBuilder, MethodSymbol method, Int32 methodOrdinal, BoundStatement block, ImmutableArray`1 lambdaDebugInfo, ImmutableArray`1 closureDebugInfo, StateMachineTypeSymbol stateMachineTypeOpt, VariableSlotAllocator variableSlotAllocatorOpt, DiagnosticBag diagnostics, DebugDocumentProvider debugDocumentProvider, ImportChain importChainOpt, Boolean emittingPdb, Boolean emitTestCoverageData, ImmutableArray`1 dynamicAnalysisSpans)
   at Microsoft.CodeAnalysis.CSharp.MethodCompiler.CompileSynthesizedMethods(TypeCompilationState compilationState)
   at Microsoft.CodeAnalysis.CSharp.MethodCompiler.CompileNamedType(NamedTypeSymbol containingType)
   at Microsoft.CodeAnalysis.CSharp.MethodCompiler.<>c__DisplayClass21_0.<CompileNamedTypeAsTask>b__0()
Stack:
   at System.Environment.FailFast(System.String, System.Exception)
   at Microsoft.CodeAnalysis.FatalError.Report(System.Exception, System.Action`1<System.Exception>)
   at Microsoft.CodeAnalysis.FatalError.ReportUnlessCanceled(System.Exception)
   at Microsoft.CodeAnalysis.CSharp.MethodCompiler+<>c__DisplayClass21_0.<CompileNamedTypeAsTask>b__0()
   at System.Collections.Immutable.ImmutableArray`1+Builder[[Microsoft.CodeAnalysis.Debugging.StateMachineHoistedLocalScope, Microsoft.CodeAnalysis, Version=2.7.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35]].set_Item(Int32, Microsoft.CodeAnalysis.Debugging.StateMachineHoistedLocalScope)
   at Microsoft.CodeAnalysis.CodeGen.ILBuilder+LocalScopeInfo.GetHoistedLocalScopes(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1<Microsoft.CodeAnalysis.Debugging.StateMachineHoistedLocalScope>)
   at Microsoft.CodeAnalysis.CodeGen.ILBuilder+ScopeInfo.GetHoistedLocalScopes[[System.__Canon, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]](Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1<Microsoft.CodeAnalysis.Debugging.StateMachineHoistedLocalScope>, Builder<System.__Canon>)
   at Microsoft.CodeAnalysis.CodeGen.ILBuilder+LocalScopeInfo.GetHoistedLocalScopes(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1<Microsoft.CodeAnalysis.Debugging.StateMachineHoistedLocalScope>)
   at Microsoft.CodeAnalysis.CodeGen.ILBuilder+ScopeInfo.GetHoistedLocalScopes[[System.__Canon, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]](Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1<Microsoft.CodeAnalysis.Debugging.StateMachineHoistedLocalScope>, Builder<System.__Canon>)
   at Microsoft.CodeAnalysis.CodeGen.ILBuilder+LocalScopeInfo.GetHoistedLocalScopes(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1<Microsoft.CodeAnalysis.Debugging.StateMachineHoistedLocalScope>)
   at Microsoft.CodeAnalysis.CodeGen.ILBuilder+ScopeInfo.GetHoistedLocalScopes[[System.__Canon, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]](Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1<Microsoft.CodeAnalysis.Debugging.StateMachineHoistedLocalScope>, Builder<System.__Canon>)
   at Microsoft.CodeAnalysis.CodeGen.ILBuilder+LocalScopeInfo.GetHoistedLocalScopes(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1<Microsoft.CodeAnalysis.Debugging.StateMachineHoistedLocalScope>)
   at Microsoft.CodeAnalysis.CodeGen.ILBuilder+ScopeInfo.GetHoistedLocalScopes[[System.__Canon, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]](Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1<Microsoft.CodeAnalysis.Debugging.StateMachineHoistedLocalScope>, Builder<System.__Canon>)
   at Microsoft.CodeAnalysis.CodeGen.ILBuilder+ScopeInfo.GetHoistedLocalScopes[[System.__Canon, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]](Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1<Microsoft.CodeAnalysis.Debugging.StateMachineHoistedLocalScope>, Builder<System.__Canon>)
   at Microsoft.CodeAnalysis.CodeGen.ILBuilder+LocalScopeInfo.GetHoistedLocalScopes(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1<Microsoft.CodeAnalysis.Debugging.StateMachineHoistedLocalScope>)
   at Microsoft.CodeAnalysis.CodeGen.ILBuilder+ScopeInfo.GetHoistedLocalScopes[[System.__Canon, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]](Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1<Microsoft.CodeAnalysis.Debugging.StateMachineHoistedLocalScope>, Builder<System.__Canon>)
   at Microsoft.CodeAnalysis.CodeGen.ILBuilder+LocalScopeInfo.GetHoistedLocalScopes(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1<Microsoft.CodeAnalysis.Debugging.StateMachineHoistedLocalScope>)
   at Microsoft.CodeAnalysis.CodeGen.ILBuilder+ScopeInfo.GetHoistedLocalScopes[[System.__Canon, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]](Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1<Microsoft.CodeAnalysis.Debugging.StateMachineHoistedLocalScope>, Builder<System.__Canon>)
   at Microsoft.CodeAnalysis.CodeGen.ILBuilder+LocalScopeInfo.GetHoistedLocalScopes(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder`1<Microsoft.CodeAnalysis.Debugging.StateMachineHoistedLocalScope>)
   at Microsoft.CodeAnalysis.CodeGen.ILBuilder+LocalScopeManager.GetHoistedLocalScopes()
   at Microsoft.CodeAnalysis.CSharp.MethodCompiler.GenerateMethodBody(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol, Int32, Microsoft.CodeAnalysis.CSharp.BoundStatement, System.Collections.Immutable.ImmutableArray`1<Microsoft.CodeAnalysis.CodeGen.LambdaDebugInfo>, System.Collections.Immutable.ImmutableArray`1<Microsoft.CodeAnalysis.CodeGen.ClosureDebugInfo>, Microsoft.CodeAnalysis.CSharp.StateMachineTypeSymbol, Microsoft.CodeAnalysis.CodeGen.VariableSlotAllocator, Microsoft.CodeAnalysis.DiagnosticBag, Microsoft.CodeAnalysis.CodeGen.DebugDocumentProvider, Microsoft.CodeAnalysis.CSharp.ImportChain, Boolean, Boolean, System.Collections.Immutable.ImmutableArray`1<Microsoft.CodeAnalysis.CodeGen.SourceSpan>)
   at Microsoft.CodeAnalysis.CSharp.MethodCompiler.CompileSynthesizedMethods(Microsoft.CodeAnalysis.CSharp.TypeCompilationState)
   at Microsoft.CodeAnalysis.CSharp.MethodCompiler.CompileNamedType(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)
   at Microsoft.CodeAnalysis.CSharp.MethodCompiler+<>c__DisplayClass21_0.<CompileNamedTypeAsTask>b__0()
   at Roslyn.Utilities.UICultureUtilities+<>c__DisplayClass5_0.<WithCurrentUICulture>b__0()
   at System.Threading.Tasks.Task.Execute()
   at System.Threading.ExecutionContext.RunInternal(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object, Boolean)
   at System.Threading.ExecutionContext.Run(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object, Boolean)
   at System.Threading.Tasks.Task.ExecuteWithThreadLocal(System.Threading.Tasks.Task ByRef)
   at System.Threading.Tasks.Task.ExecuteEntry(Boolean)
   at System.Threading.ThreadPoolWorkQueue.Dispatch()
