using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTest
{
				[TestFixture]
				class StackTests
				{
								[Test]
								public void Push_ArgIsNull_ThrowArgNullException()
								{
												var stack = new Fundamentals.Stack<string>();

												Assert.That(() => stack.Push(null), Throws.ArgumentNullException);
								}

								[Test]
								public void Push_ValidArg_AddObjectToStack()
								{
												var stack = new Fundamentals.Stack<string>();

												stack.Push("a");

												Assert.That(stack.Count, Is.EqualTo(1));
								}

								[Test]
								public void Pop_EmptyStack_ThrowInvalidOperationException()
								{
												var stack = new Fundamentals.Stack<string>();

												Assert.That(() => stack.Pop(), Throws.InvalidOperationException);
								}

								[Test]
								public void Pop_StackWithFewObjects_ReturnObjectOnTheTop()
								{
												var stack = new Fundamentals.Stack<string>();
												stack.Push("a");
												stack.Push("b");
												stack.Push("c");

												var result = stack.Pop();

												Assert.That(result, Is.EqualTo("c"));
								}

								[Test]
								public void Pop_StackWithFewObjects_RemoveObjectOnTheTop()
								{
												var stack = new Fundamentals.Stack<string>();
												stack.Push("a");
												stack.Push("b");
												stack.Push("c");

												stack.Pop();

												Assert.That(stack.Count, Is.EqualTo(2));
								}

								[Test]
								public void Peek_EmptyStack_ThrowInvalidOperationException()
								{
												var stack = new Fundamentals.Stack<string>();

												Assert.That(() => stack.Peek(), Throws.InvalidOperationException);
								}

								[Test]
								public void Peek_StackWithFewObjects_ReturnObjectOnThetop()
								{
												var stack = new Fundamentals.Stack<string>();
												stack.Push("a");
												stack.Push("b");
												stack.Push("c");

												var result = stack.Peek();

												Assert.That(result, Is.EqualTo("c"));
								}

								[Test]
								public void Peek_StackWithFewObjects_KeepTheSameStackCount()
								{
												var stack = new Fundamentals.Stack<string>();
												stack.Push("a");
												stack.Push("b");
												stack.Push("c");

												stack.Peek();

												Assert.That(stack.Count, Is.EqualTo(3));
								}

				}
}
