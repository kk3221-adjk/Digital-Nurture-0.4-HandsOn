````markdown
# 📈 Understanding Big O Notation and Time Complexity

---

## 🕒 What is Time Complexity?

**Time Complexity** is **not** the actual runtime of an algorithm.  
Instead, it describes how the **number of operations grows** relative to the input size **n**.

It is a **mathematical function** that expresses the growth of an algorithm's steps with increasing input size.

For example:

```c
for (int i = 0; i < n; i++) {
    print(arr[i]);
}
````

This loop executes `n` times.
If `n = 10`, let's say it takes 10 seconds.
If `n = 100`, it takes 100 seconds.
→ So the **operations grow linearly** with input size.

This is an example of **linear time complexity**, represented as:

```
O(n)
```

---

### 📊 Visualizing Time Complexity

![Time Complexity Graph](https://github.com/user-attachments/assets/1f52754a-c671-4b6a-a26c-736943f3eba0)

This graph shows how different time complexities behave with increasing input size:

* `O(1)` → Constant time
* `O(log n)` → Logarithmic
* `O(n)` → Linear
* `O(n log n)` → Linearithmic
* `O(n²)` → Quadratic

---

## 🧮 Big O Notation

### ✅ Definition:

**Big O notation** is a formal way to describe the **worst-case** performance of an algorithm.

It gives an **upper bound** on the number of operations an algorithm might perform, helping us understand its scalability.

---

## 📚 Best, Average, and Worst Case Scenarios (Search Operations)

Let's take the example of **Linear Search** and **Binary Search**.

---

### 🔍 Linear Search

**Concept**: Search each element one by one in an array of size `n`.

| Case        | Description                      | Time Complexity   |
| ----------- | -------------------------------- | ----------------- |
| **Best**    | Element found at the first index | `O(1)`            |
| **Average** | Element is in the middle         | `O(n/2)` ≈ `O(n)` |
| **Worst**   | Element not found or last index  | `O(n)`            |

---

### 🔎 Binary Search (sorted arrays only)

**Concept**: Repeatedly divide the array in half and search in the relevant half.

| Case        | Description                    | Time Complexity |
| ----------- | ------------------------------ | --------------- |
| **Best**    | Element found at the middle    | `O(1)`          |
| **Average** | Element found in log₂(n) steps | `O(log n)`      |
| **Worst**   | Search all levels              | `O(log n)`      |

---

## 🧠 Why Big O Helps in Algorithm Analysis

* **Language-Independent**: Focuses on logic, not hardware or programming language.
* **Predictive**: Helps estimate algorithm performance for large inputs.
* **Comparative**: Makes it easier to compare two algorithms.

---

## 🛠 Example: Comparing Time Complexities

```csharp
// O(n) - Linear
for (int i = 0; i < n; i++)
    Console.WriteLine(arr[i]);

// O(n^2) - Quadratic
for (int i = 0; i < n; i++)
    for (int j = 0; j < n; j++)
        Console.WriteLine(i + "," + j);

// O(log n) - Binary Search
int BinarySearch(int[] arr, int target) {
    int low = 0, high = arr.Length - 1;
    while (low <= high) {
        int mid = (low + high) / 2;
        if (arr[mid] == target)
            return mid;
        else if (arr[mid] < target)
            low = mid + 1;
        else
            high = mid - 1;
    }
    return -1;
}
```

---

## 📦 Summary Table of Common Time Complexities

| Complexity   | Name         | Example Use Case                 |
| ------------ | ------------ | -------------------------------- |
| `O(1)`       | Constant     | Accessing an array element       |
| `O(log n)`   | Logarithmic  | Binary search                    |
| `O(n)`       | Linear       | Linear search                    |
| `O(n log n)` | Linearithmic | Merge sort, Quick sort (average) |
| `O(n²)`      | Quadratic    | Bubble sort, Selection sort      |
| `O(2ⁿ)`      | Exponential  | Recursive Fibonacci              |
| `O(n!)`      | Factorial    | Traveling Salesman, permutations |


## ✅ Conclusion

* Big O helps you understand **scalability** and **efficiency**.
* Analyze best, average, and worst cases for **search**, **sort**, and **recursion**-based algorithms.
* Always aim for lower time complexity when possible!
