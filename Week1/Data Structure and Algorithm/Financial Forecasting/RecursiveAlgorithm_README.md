````markdown
# Understanding Recursive Algorithms 🌀

## What is Recursion?

Recursion is a programming technique where a function calls **itself** to solve smaller instances of the same problem :contentReference[oaicite:1]{index=1}. A recursive routine typically consists of:

1. **Base case** – a simple condition that stops further recursion.
2. **Recursive case** – where the function calls itself with a reduced or simpler input :contentReference[oaicite:2]{index=2}.

This creates a call stack: new instances are "pushed" until the base case, then "unwound" back up with processed results :contentReference[oaicite:3]{index=3}.

---

## 🧠 Why Use Recursion?

Recursion helps **break problems** into digestible chunks:

- Ideal for **divide‑and‑conquer** strategies (e.g., merge sort, quicksort) :contentReference[oaicite:4]{index=4}.
- Simplifies operations on **nested or hierarchical data**, like trees and graphs (e.g., DFS) :contentReference[oaicite:5]{index=5}.
- Elegant solutions for **mathematical sequences** like factorials, Fibonacci, GCD, Towers of Hanoi :contentReference[oaicite:6]{index=6}.

---

## Examples

### 1. Factorial

```pseudo
factorial(n):
    if n == 0:
        return 1            # base case
    return n * factorial(n - 1)  # recursive case
````

Computes *n!* by multiplying by (n-1)! ([en.wikipedia.org][1]).

### 2. Fibonacci

```pseudo
fib(n):
    if n == 0: return 0
    if n == 1: return 1
    return fib(n - 1) + fib(n - 2)
```

A classic case of **multiple recursion**—though slower without optimization ([haase1020.medium.com][2]).

### 3. GCD (Euclidean Algorithm)

```pseudo
gcd(a, b):
    if b == 0:
        return a
    return gcd(b, a % b)
```

An efficient, **tail-recursive** implementation ([geeksforgeeks.org][3]).

### 4. Tree & Graph Traversal

Depth‑First Search recursively explores each branch before backtracking—great for trees or maze solving ([en.wikipedia.org][4]).

---

## 🛠️ Pros & Cons

### ✅ Advantages

* **Clarity**: Recursive code often mirrors problem definition.
* Great for **hierarchical data** and recursive formulas.
* Enables straightforward **divide‑and‑conquer** solutions ([algocademy.com][5], [en.wikipedia.org][6]).

### ⚠️ Drawbacks

* Can cause **stack overflows** without a proper base case ([geeksforgeeks.org][3]).
* **Performance overhead**: slower and memory heavier than iteration ([haase1020.medium.com][2]).
* Some problems (e.g., naive Fibonacci) exhibit **exponential time**—can improve with **memoization** ([algocademy.com][5]).

---

## ✨ Tips for Writing Good Recursive Functions

1. **Define a clear base case** to prevent infinite recursion ([medium.com][7]).
2. **Solve smaller intermediate problems**, then combine results.
3. **Prefer tail recursion** where possible to reduce call stack depth ([geeksforgeeks.org][8]).
4. **Use memoization** to optimize overlapping subproblems .

---

## ✅ When to Use Recursion

Recursion is appropriate when:

* The problem naturally splits into subproblems of the same form ([geeksforgeeks.org][8]).
* You can **clearly define a base case** and ensure termination.
* The cleaner, more intuitive recursive solution outweighs performance considerations.

---
