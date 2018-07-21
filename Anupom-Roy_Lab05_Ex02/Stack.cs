﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anupom_Roy_Lab05_Ex02
{
    public class Stack<T>
    {
        private int top; // location of the top element
        private T[] elements; // array that stores stack elements

        // parameterless constructor creates a stack of the default size
        public Stack() : this(10) // default stack size
        {
            // empty constructor; 
        }
        // constructor creates a stack of the specified number of elements
        public Stack(int stackSize)
        {
            if (stackSize <= 0) // validate stackSize
            {
                throw new ArgumentException("Stack size must be positive.");
            }

            elements = new T[stackSize]; // create stackSize elements
            top = -1; // stack initially empty
        }

        // push element onto the stack; if unsuccessful,
        // throw FullStackException
        public void Push(T pushValue)
        {
            if (top == elements.Length - 1) // stack is full
            {
                throw new FullStackException(
                   $"Stack is full, cannot push {pushValue}");
            }

            ++top; // increment top
            elements[top] = pushValue; // place pushValue on stack
        }
        // return the top element if not empty,
        // else throw EmptyStackException
        public T Pop()
        {
            if (top == -1) // stack is empty
            {
                throw new EmptyStackException("Stack is empty, cannot pop");
            }

            --top; // decrement top
            return elements[top + 1]; // return top value
        }


    }
}
