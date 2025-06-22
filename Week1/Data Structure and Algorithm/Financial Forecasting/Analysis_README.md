```markdown
# 📊 Algorithm Analysis: Financial Forecasting Tool

### ⏱ Time Complexity
- **O(n)** – Linear time complexity, where `n` is the number of years to forecast.
- Each recursive call computes the result for one year, leading to `n` calls.

### 🧠 Space Complexity
- **O(n)** – Due to the recursive call stack.
- For each year, a new frame is added to the stack until the base case is reached.

---

### 🛠 Optimization Strategies

1. **Memoization**  
   - Store previously computed results in a cache (e.g., dictionary) to avoid redundant calculations.

2. **Iterative Approach**  
   - Replace recursion with a loop to avoid stack overflow and improve memory efficiency.

3. **Tail Recursion**  
   - If supported by the compiler, tail recursion can optimize recursive calls by reusing stack frames.

---
```
