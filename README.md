![build](https://github.com/amlsantos/parrot-kata-refactoring/actions/workflows/build.yml/badge.svg)
![test](https://github.com/amlsantos/parrot-kata-refactoring/actions/workflows/test.yml/badge.svg)

# Parrot Refactoring Kata

This is my solution for the Parrot kata, a famous refactoring exercise designed to improve code readability, maintainability, and design. 
This kata focuses on refactoring a poorly written program that simulates a parrot, with the goal of making the code more elegant and easier to understand.

## Getting Started

Clone or download the Parrot Refactoring Kata repository:

```bash
git clone https://github.com/emilybache/Parrot-Refactoring-Kata.git
cd Parrot-Refactoring-Kata
```

## Exercise Overview

### Parrot Simulator

The code in this kata simulates a parrot and its behavior, including different species of parrots and their ability to speak. The existing implementation is not ideal and could benefit from various refactoring techniques to improve its quality.

### Goals

1. **Improve Code Readability**: Enhance the clarity of the code by improving variable names, method names, and overall structure.

2. **Eliminate Code Duplication**: Identify and remove redundant or duplicated code.

3. **Increase Testability**: Make the code more testable by reducing dependencies and improving modularity.

4. **Apply Design Patterns**: Consider using design patterns to improve the overall design of the parrot simulator.

## Refactorings

### Replace Type Code with Subclasses

Introduce subclasses for different types of parrots (e.g., `EuropeanParrot`, `AfricanParrot`, `NorwegianBlueParrot`). Replace the existing type code with instances of these subclasses, allowing each type to have its own behavior.

### Replace Conditional with Polymorphism

Identify areas where conditional statements are used to determine the behavior of different parrot types. Replace these conditionals with polymorphic behavior by leveraging the introduced subclasses and their overridden methods.

## Project Structure

```plaintext
Parrot-Refactoring-Kata/
|-- src/
|   |-- Domain/
|       |-- Parrot.cs
|       |-- ParrotTypes.cs
|       |-- EuropeanParrot.cs
|       |-- AfricanParrot.cs
|       |-- NorwegianBlueParrot.cs
|   |-- Domain/
|       |-- Program.cs
|-- tests/
|   |-- UnitTests/
|       |-- ParrotTests.cs
|-- .gitignore
|-- README.md
|-- LICENSE
```
## Inspiration

Watch this [inspiring YouTube video](https://www.youtube.com/watch?v=KW-jvdZ8a_Y) where `Anthony Sciamanna` refactor code to improve its quality. Use this as motivation and guidance for your own refactoring process.

## Acknowledgments

- This kata was created by [Emily Bache](https://github.com/emilybache), and you can find the original repository [here](https://github.com/emilybache/Parrot-Refactoring-Kata).

