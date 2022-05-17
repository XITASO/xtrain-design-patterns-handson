---
marp: true
theme: mytheme
style: |
    section.small li {
        font-size: 20pt;
    }
footer: Workshop Design Patterns | 2022
backgroundImage: url(xitasoblack.png)
---

# Workshop Design Patterns

Thomas Ziemek & Alex Rampp

---

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

## Design Patterns

- Creational
- Structural
- Behavioral

---

### Creational

- Factory
- Builder
- Prototype
- Singleton

---

#### Factory Method

![w:700](Images\factory-method.png "https://refactoring.guru/images/patterns/content/factory-method/factory-method-en-2x.png")

---

#### Factory Method

- expose interface
- concrete type is only implementation detail
- seperate construction from usage
- contain dependencies needed for construction
---

#### Builder

![w:700](Images\builder.png "a title")

---

#### Builder

- construct complex objects step by step
- construct object trees
- TestDataBuilder
- use Director to hide builder steps

---

#### Prototype

![w:700](Images\prototype.png "a title")

---

#### Prototype

<!-- 
Problem:
- copy from outside may not know private fields
- may only know interface

 -->
- copy existing objects
- object itself is responsible
- ICloneable
- mitotic cell devision

---

#### Singleton

![w:700](Images\singleton.png "a title")

---

#### Singleton

<!-- 
Government
-->
- one instance
- public accessible
- threading :-(
- tests :-(


---

### Structural

- Adapter
- Proxy
- Decorator
- Bridge
- Composite
- Facade
- Flyweight

---

#### Adapter

![w:700](Images\adapter.png "https://refactoring.guru/images/patterns/content/adapter/adapter-en-2x.png")

---

#### Adapter

- Anti-Corruption-Layer, DAL
- not a POCO
- using 3rd party libs or objects you can't change
- different interface 

---

#### Proxy

![w:700](Images\Proxy.png "a title")

---

#### Proxy

- lazy initialization
- access control
- api client
- same interface

---

#### Decorator

![w:700](Images\Decorator.png "https://refactoring.guru/images/patterns/content/decorator/decorator-2x.png")

---

#### Decorator

- attach new behavior
- extension of a wrapper
- don't break the flow of request (-> CoR)
- enhanced interface

---

#### Bridge

![w:700](Images\bridge.png "https://refactoring.guru/images/patterns/content/bridge/bridge-2x.png")

---

#### Bridge
<!-- universal remote controls -->
- composition over inheritance
- multi platform frameworks
- switch implementation at runtime
- ORM "wrapper"

---

#### Composite

![w:700](Images\Composite.png "https://refactoring.guru/images/patterns/content/composite/composite-2x.png")

---

#### Composite
<!-- WPF layouting -->
- tree structure
- common interface
- i.e. price/space calculation

---

#### Facade

![w:700](Images\Facade.png "https://refactoring.guru/images/patterns/content/facade/facade-2x.png")

---

#### Facade
<!-- new interface for existing objects, system of objects -->
- simplified interface
- web API

---

### Behavioral

- Chain of Responsibility
- Command
- Mediator
- Memento
- Observer
- State
- Strategy
- Template Method

---

### Chain of Responsibility

![w:700](Images\chain-of-responsibility.png "https://refactoring.guru/images/patterns/content/chain-of-responsibility/chain-of-responsibility-2x.png")

---

### Chain of Responsibility
<!-- compare with decorator -->

- short circuit
- support hotline
- ASP.NET Core request pipeline

---

#### Command

![w:700](Images\Command.png "https://refactoring.guru/images/patterns/content/command/command-en-2x.png")

---

#### Command
<!-- unidirectional connection, restaurant order! -->
- request as standalone object
- contains all information
- supports undoable actions
- queue/schedule operations

---

#### Mediator

![w:700](Images\Mediator.png "https://refactoring.guru/images/patterns/content/mediator/mediator-2x.png")

---

#### Mediator
<!-- no connection! flight control -->
- reduce dependencies
- reduce cohesion

---

#### Observer

![w:700](Images\Observer.png "https://refactoring.guru/images/patterns/content/observer/observer-2x.png")

---

#### Observer
<!-- unidirectional connection -->
- event notification through subscription
- dynamic changes
- coupling!

---

#### Memento

![w:700](Images\Memento.png "https://refactoring.guru/images/patterns/content/memento/memento-en-2x.png")

---

#### Memento

- save and restore previous state
- own object is responsible
- can access private fields
- history

---

#### State

![w:700](Images\State.png "https://refactoring.guru/images/patterns/content/state/state-en-2x.png")

---

#### State

- finite state machine

---

#### Template Method

![w:700](Images\Template-Method.png "https://refactoring.guru/images/patterns/content/template-method/template-method-2x.png")

---

#### Template Method
<!-- factory method is specialized template method -->
- skeleton in base class
- specify certain steps of an algorithm
- based on inheritance

---

#### Strategy

![w:700](Images\Strategy.png "https://refactoring.guru/images/patterns/content/strategy/strategy-2x.png?id=1cee47d05a76fddf07dce9c67b700748")

---

#### Strategy
<!-- routing algorithms -->
- describe different ways of doing the same thing
- similar classes with different behavior
- isolate business logic from implementation details
- based on composition

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