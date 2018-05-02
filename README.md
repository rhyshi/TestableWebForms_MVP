# TestableWebForms_MVP
MVP Implementation to allow WebForms (in VB) to be testable/injectable

Followed this tutorial http://www.bradoncode.com/blog/2012/04/mvp-design-pattern-survival-kit.html


## Problem
Older style software application frameworks like .NET WebForms and Winforms are notoriously difficult to test. There tends to be a lot of logic (business and UI) in the code-behind portion which is almost untestable (not including manual testing).

## Solution: MVP Design Pattern
Model View Presenter is a good and well documented method/pattern to make these older systems testable. 

![alt-text](.\mvp-pattern.jpg)

