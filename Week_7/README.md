# JavaScript ES6 Concepts

This document outlines key features introduced in ECMAScript 2015 (ES6) and provides explanations of specific concepts including `let`, `const`, `class`, `arrow functions`, and more.

---

## Features of ES6

- **Block Scoped Variables (`let`, `const`)**
- **Arrow Functions** for concise function expressions
- **Classes** and **Inheritance**
- **Template Literals** for easier string interpolation
- **Destructuring Assignment** for arrays and objects
- **Default Parameters** in functions
- **Rest and Spread Operators**
- **Promises** for asynchronous programming
- **Modules** for exporting and importing code
- **`Map` and `Set` Data Structures**

---

## JavaScript `let`

- `let` declares a block-scoped local variable.
- Unlike `var`, it is not hoisted to the top of the enclosing function or global scope.
- It can be updated but not redeclared within the same scope.

**Example:**
```js
let count = 10;
count = 20; 
let count = 30; // SyntaxError: Identifier 'count' has already been declared
## Difference Between var and let

| Feature        | var                                | let                              |
|----------------|-------------------------------------|----------------------------------|
| Scope          | Function-scoped                    | Block-scoped                     |
| Redeclaration  | Allowed                            | Not allowed in same scope        |
| Hoisting       | Yes, initialized as undefined      | Yes, but not initialized         |
| Global Object  | Adds to global window object       | Does not add to global object    |

 JavaScript const

- const declares a block-scoped constant variable.
- Must be initialized at the time of declaration.
- Cannot be reassigned, but for objects and arrays, properties/elements can be changed.