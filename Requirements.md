---
marp: true
theme: uncover
title: Workshop Design Patterns
style: |
    section.small li {
        font-size: 20pt;
    }
---

# Workshop Design Patterns

Thomas Ziemek & Alex Rampp

---
<!-- paginate: true -->

# Agenda

* Introduction
* Hands-On
* Pause
* Hands-On
* Discussion

---

## Introduction

SOLID

---

## Handson

We want to develop a Task API in an agile way.

---
### Sprint 1

- As a user, I want to add **Task** items.
    - A **Task** item has a *title*.
- As a user, I want to retrieve indiviual tasks.
- As a user, I want to update the title of a specific task.
- As a user, I want to mark a task as completed.

<!-- 
- Facade -> API
- Adapter for DTOs
-> explain Proxy and Decorator

- Factory -> static creation method
- Builder for tests
- Template Method for specific builders
- DbContext -> Repository, UnitOfWork
- Chain of Responsibility (ASP Pipeline)
-->

---
### Sprint 2

- As a user, I want to add **Project** items.
    - A **Project** item has a *title*, a *description*, an *assigned user* (eMail) and a *deadline*.
- As a user, I want to retrieve indiviual projects.
- As a user, I want to update the individual properties of a project.

---
### Sprint 3

- As a user, I want to add a task to a project.
    - A task can only be assigned to one project.
- As a user, I want to retrieve a list of all projects with their title, deadline and status.
    - A project is complete, when all tasks are complete.
<!--
- Composite: Completed state of project depends on tasks
-->

---
### Sprint 4

- As a user, I want to add another type of task to a project, a **Goal**.
    - A **Goal** has a title, a description and a due date.
    - I want to execute the same actions as for a task.
- When a project is complete a mail should be sent to the assigned user.

<!--
- Factory -> Factory method & abstract factory
- Observer or Mediator for completion
-> Observer (one way connection between two objects)
-> Mediator (eliminate mutual dependencies )
-->

---

## More

---

- Singleton <!-- static or singleton class => service -->
- Service Locator - Anti-Pattern? <!-- IServiceCollection; Locator -->
- Strategy <!-- Xml, Json, Database -->
- Command <!-- use a class which captures state and logic, instead of a simple method -->

---

## Beyond design patterns

- Specification <!-- check models against it, create something with it -->
- Primitive Obession/Value Objects <!-- use concrete types instead of language naturals -->
- Anemic domain model - Anti-Pattern? <!-- dumb data classes -->

---

> "Any fool can write code that **a computer** can understand. Good programmers write code that **humans** can understand" - *Martin Fowler*

---

## Critics to SOLID

---

### Properties over principles

**Principles** are rules or guideline
- define conditions or boundaries
- Code conforms to them or is wrong

---

### Properties over principles

**Properties** are qualities or characteristics
- define a goal or centre to move towards
- Code is closer to or further from the centre

---

### Properties over principles

**Properties** should be
- practical (easy to articulate, easy to access, easy to adopt)
- human (from the perspective of people, not code)
- layered (guidance for beginners, nuance for experienced)

---

## CUPID

* Composable (plays well with others)
* Unix philosophy (does one thing well)
* Predictable (does what you expect)
* Idiomatic (feels natural)
* Domain-based (in language and structure)

---

Dan North
https://dannorth.net/2021/03/16/cupid-the-back-story/

Response from Uncle Bob
https://blog.cleancoder.com/uncle-bob/2020/10/18/Solid-Relevance.html

---

# Happy Coding