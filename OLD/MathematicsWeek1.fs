
module MathematicsWeek1

open CommonLatex
open LatexDefinition
open CodeDefinitionLambda
open Interpreter


let slides =
  [
    Section("Introduction")
    SubSection("Course overview")
    ItemsBlock
      [
        !"Sets"
        !"Functions"
        !"Graphs"
        !"Categories with practical examples"
      ]
    Section("Sets")

    SubSection("Sets")
    VerticalStack
      [
        ItemsBlockWithTitle "Specification"
          [
            ! @"A \textbf{set} is a mathematical entity that is distinct from, but completely determined by, its elements (if any)."
            ! @"For every entity $x$ and set $S$, the statement $x \in S$, read `$x$ is an element of $S$', is a sentence that is either \texttt{true} or \texttt{false}."
        ]
        ItemsBlockWithTitle "Example"
          [
            ! @"${1, 3, 5}$	 is a set completely determined by the facts that its elements re the numbers 1, 3, and 5."
            ! @"The set ${ }$ with no elements is called the \textbf{empty set} and is denoted as $\emptyset$"
          ]
      ]

    SubSection("Setbuilder notation")
    ItemsBlock
      [
          ! @"Defines a set as the collection of entities that satisfy a predicate."
          ! @"If $x$ is a variable ranging over a specific data type and $P(x)$ is a predicate about the data type, then the notation $\{x | P(x)\}$ denotes the set of all \textit{things} that have the same type as $x$ about which $\{x | P(x)\}$ is \texttt{true}."
      ]
    SubSection("Setbuilder notation - example")
    ItemsBlock
        [
          ! @"$\{x | x > 7 \wedge x < 10\}$ is the set of real numbers\footnote{In mathematics, a real number is a value that represents a quantity\\ along a continuous line. The real numbers include all the rational numbers, such as the integer −5 and the fraction 4/3, and all the irrational numbers,\\ such as $\sqrt 2$.} greater that 7 and less than 10.\footnote{The statement $A \wedge B$, read $A$ and $B$.}"
          ! @"The set $\{x | P(x)\}$ is called the \textbf{extension} of the predicate $P$."
        ]

      
    SubSection("Notation")
    VerticalStack
      [
        ItemsBlockWithTitle "Natural numbers $\mathbb{N}$"
          [
            ! @"The set of non-negative integers $\{0, 1, 2, 3, \dots\}$"
        ]
        ItemsBlockWithTitle "Integer numbers $\mathbb{Z}$"
          [
            ! @"Like the set $\mathbb{N}$, but also including negative integers $\{ \dots, -2, -1, 0, 1, \dots \}$"
          ]
        ItemsBlockWithTitle "Real numbers $\mathbb{R}$"
          [
            ! @"\textit{Nearly any number you can think of is a Real Number}."
          ]
        ItemsBlockWithTitle "Rational numbers $\mathbb{Q}$"
          [
            ! @"A Rational Number is a real number that can be written as a simple fraction (i.e. as a ratio) of two integer numbers."
            ! @"\textbf{Example}: $1.5$ is a rational number because $1.5 = \frac{3}{2}$ (it can be written as a fraction)."
          ]
      ]

    SubSection("Russell paradox")
    ItemsBlock
      [
          ! @"The \textbf{setbuilder notation} (which implicitly supposes that every predicate determines a set) has bug."
          ! @"\centering $\{S|S \,is \,a \,set \, \wedge \,S \notin S \}$"
          ! @"\flushleft Is the set of all those sets that are not elements of themselves"
          ! @"If this were indeed a set $T$, then $T \in T$ implies by definition that $T \notin T$, whereas $T \notin T$ implies by definition that $T \in T$. This contradiction shows that these is no such set $T$."
      ]
    SubSection("Russell paradox example: the barber paradox")
    ItemsBlock
      [
          ! @"The barber is the ``\textit{one who shaves all those, and those only, who do not shave themselves.}'' The question is, \textbf{does the barber shave himself?}"
          ! @"Answering this question results in a contradiction. The barber cannot shave himself as he only shaves those who do not shave themselves. As such, if he shaves himself he ceases to be a barber. If the barber does not shave himself then he fits into the group of people who would be shaved by the barber (and, so, as the barber he needs to shave himself)."
      ]

    VerticalStack
      [
        ItemsBlockWithTitle "Cartesian product"
          [
            ! @"If $S$ and $T$ are sets, the \textbf{cartesian product} of $S$ and $T$ is the set $S \times T$ of ordered pairs $(s, t)$ with $s \in S$ and $t \in T$. Thus the setbuilder notation $S \times T = \{ (s,t) | s \in S \wedge t \in T \}$."
            ! @"Observe that $S \times T \neq T \times S$ unless $S = T$"
        ]
        ItemsBlockWithTitle "Ordered \\textit{n}-tuple"
          [
            ! @"A sequence $(a_1,\dots,a_n)$  determined by the fact that for $i=1\dots n$, the $i$th coordinate of $(a_1,\dots,a_n)$ is $a_i$."
            ! @"Then the cartesian product $S_1 \times S_2 \times \dots S_n$ is the set of $n$-tuples $(a_1,\dots,a_n)$ with $a_i \in S_i$, for $i=1,\dots,n$."
          ]
      ]
    VerticalStack
      [
        ItemsBlockWithTitle "Relation"
          [
            ! @"A \textbf{relation} $\alpha$ from a set $S$ to a set $T$ is a subset of $S \times T$."
            ! @"If $\alpha$ is a relation from $S$ to $T$, then we write $s \alpha t$ to mean that $(s,t) \in \alpha$."
        ]
        ItemsBlockWithTitle "Example: diagonal relation $\Delta_S$"
          [
            ! @"$\Delta_S$ from $S$ to $S$ for anyn set $S$ is defined by:"
            ! @"\centering $\Delta_S = \{ (x,x) | x \in S \}$"
          ]
        ItemsBlockWithTitle "Example: `$<$' on $\mathbb{R}$"
          [
            ! @"The order relation `$<$' is the set:"
            ! @"$\{ (r,s) \, | \, \text{There is a positive number } t \text{such that } r + t = s \}$"
          ]
      ]
  ]

