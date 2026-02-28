```markdown
# AGENTS.md - Guidelines for AI Coding Agents

These guidelines outline the principles and rules for development of AI coding agents within this repository. Adherence to these principles ensures code maintainability, robustness, and efficiency.

## 1. DRY (Don't Repeat Yourself)

- All code should have single, well-defined responsibilities.
- Avoid duplicating functionality across multiple files or components.
- Implement reusable components and functions to minimize code bloat.
- When necessary, leverage existing libraries or modules and reuse them effectively.

## 2. KISS (Keep It Simple, Stupid)

- Prioritize clarity and readability.
- Design solutions that are easily understood and debugged.
- Avoid unnecessary complexity.
- Keep code concise and focused.

## 3. SOLID Principles

- **Single Responsibility Principle:** Each class/component should have one, and only one, reason to change.
- **Open/Closed Principle:**  The system should be open for extension but closed for modification.
- **Liskov Substitution Principle:**  Subclasses should be substitutable for their base classes without altering the correctness of the program.
- **Interface Segregation Principle:** Clients should not be forced to implement interfaces they do not use.
- **Dependency Inversion Principle:** Interfaces should be replaced by implementations.

## 4. YAGNI (You Aren't Gonna Need It)

- Avoid implementing features or components that are not currently required.
- Only implement functionality that is explicitly defined or necessary for the immediate task.
- Refactor existing code to remove unnecessary implementation details.

## 5. Code Structure & Organization

- **File Naming Conventions:**  Use a consistent naming scheme across all files (e.g., `[ComponentName]_[FunctionName].py`).
- **Modularization:** Break down complex tasks into smaller, manageable functions and classes.
- **Dependency Management:** Clearly document dependencies between modules and components.
- **Comments:**  Write clear, concise, and informative comments.  Focus on explaining *why* rather than *what*.
- **Documentation:** Provide detailed documentation for each module, class, and function.

## 6.  Development Workflow & Standards

- **Version Control:** Utilize Git for version control. Track changes thoroughly with descriptive commit messages.
- **Code Reviews:**  All changes must undergo thorough code review before merging.
- **Testing:** All unit tests must be included in each file.  Coverage should be >80% for all modules.
- **Dependency Management:**  Use a dependency management tool (e.g., `pip`, `conda`) to manage external libraries.
- **Static Analysis:** Utilize static analysis tools (e.g., `flake8`, `mypy`) to identify potential issues early.

## 7.  Specific Considerations for AI Agents

- **State Management:**  Clearly define and manage agent states, using appropriate data structures.
- **Action Planning:** Implement robust action planning algorithms to determine appropriate actions.
- **Reward Shaping:**  Consider using techniques for reward shaping to guide the AI's learning process.
- **Error Handling:**  Implement graceful error handling to prevent crashes and provide informative feedback.

## 8.  Code Length & Complexity Limits

- **Maximum Lines of Code:**  Each file must not exceed 180 lines of code.
- **Code Complexity Analysis:** Use tools to assess code complexity (e.g., cyclomatic complexity) and identify areas for simplification.

## 9.  Testing & Validation

- **Unit Tests:** All functions and classes must have comprehensive unit tests.
- **Integration Tests:**  Integration tests should validate the interaction between different components.
- **Edge Case Tests:**  Specifically test edge cases and boundary conditions.
- **Regression Tests:**  Implement regression tests to ensure existing functionality remains intact after code changes.

## 10.  Deliverables

- **Initial Testing:** All files must pass initial tests (at least 80% coverage).
- **Code Review Reports:**  Provide detailed code review reports with identified issues and recommendations.
- **Documentation Updates:**  Update documentation as needed based on code changes.

These guidelines are subject to change as the project evolves.  Regular review and updates are encouraged.
```