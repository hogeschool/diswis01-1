
module MathematicsWeek3

open CommonLatex
open LatexDefinition
open CodeDefinitionLambda
open Interpreter


let slides =
  [
    Section("Graphs")

    SubSection("Deﬁnition and notation")
    ItemsBlock
      [
          ! @"A graph is made of \textbf{nodes} and \textbf{arrows}."
          ! @"Each arrow has a \textbf{source} (domain) and \textbf{target} (codomain)."
          ! @"The notation `$f : a \longrightarrow b $' means that $f$ is an arrow and $a$ and $b$ are its source and target, respectively." 
          ! @"There may be one or more arrows – or none at all – with given nodes as source and target"
          ! @"An arrow with the same source and target node will be called an \textbf{endoarrow} or \textbf{endomorphism} of that node."
      ]

    ItemsBlock
      [
          ! @"We will denote the collection of nodes of a graph $\mathcal{G}$ by $G_0$ and the collection of arrows by $G_1$, and similarly with other letters ($\mathcal{H}$ has nodes $H_0$, $\mathcal{C}$ has nodes $C_0$, and so on)."
          ! @"In literature it is often the case that a graph $\mathcal{G}$ is denoted as a pair $(V, E)$ where $V$ is a finite set and $E$ is a binary relation on $V$. The set $V$ is called \textbf{vertex set} of $\mathcal{G}$ (and its elements are called \textbf{vertices}). The set $E$ is called \textbf{edge set} of $\mathcal{G}$ (and its elements are called \textbf{edges})."
      ]

    SubSection("Example")
    ItemsBlock
      [
          ! @" Let $G_0$ =\{1,2\}"
          ! @" Let $G_1$ =\{a,b,c\},"
          ! @"[]source($a$) = target($a$) = source($b$) = target($c$) = 1 $\wedge$"
          ! @"[]target($b$) = source($c$) = 2 "
          ! @"Then we can represent $\mathcal{G}$ as"
          Image("graph1", 0.5)
      ]

    SubSection("Small and large graphs")
    ItemsBlock
      [
          ! @" A graph that has a \texttt{set} of nodes and arrows is a \textbf{small graph}; otherwise, it is a \textbf{large graph}."          
      ]
    
    SubSection("Discrete graph")
    ItemsBlock
      [
          ! @"A graph is called \textbf{discrete} if it has no arrows."
          ! @"The empty graph, with no nodes and no arrows, is discrete." 
          ! @"A small discrete graph is essentially a set"
      ]
    SubSection("Finite graph")
    ItemsBlock
      [
          ! @"A graph is \textbf{ﬁnite} if the number of nodes and arrows is ﬁnite."
      ]

    SubSection("Example")
    ItemsBlock
      [
          ! @"It is often convenient to picture a relation on a set as a graph."
          ! @"Let A =\{1,2,3\}, B =\{2,3,4\} and "
          ! @"[] $\alpha$ = \{ (1,2),(2,2),(2,3),(1,4) \} "
          ! @"Then $\alpha$ can be pictured as"
          ! @"[] \centering"
          Image("graph2", 0.5)
          ! @"Note that the graph of a function, as deﬁned in the previous lecture, is a relation and so corresponds to a graph."
      ]
    SubSection("Graph of a function - remark")
    ItemsBlock
      [
          ! @"Note that the graph of a function, as deﬁned in the previous lecture, is a relation and so corresponds to a graph."
          ! @"The resulting picture has an arrow from each element $x$ of the domain to $f(x)$ so it is not the graph of the function in the sense used in calculus."

      ]

    SubSection("Example")
    ItemsBlock
      [
          ! @"Sometimes one can represent a data structure by a graph. The following graph represents the set $\mathbb{N}$ of natural numbers in terms of zero and the successor function (adding 1):"
          Image("graph3", 0.5)
          ! @"The name ‘1’ for the left node is the conventional notation to require that the node denote a \textbf{singleton set}, that is, a set with exactly one element."
      ]

    SubSection("Example in C\#")
    ItemsBlock
      [
          ! @"And now some practical example on the computer"
          ! @"A counter"
      ]
    SubSection("Example in C\#")
    ItemsBlock
      [
          ! @"And now some practical example on the computer"
          ! @"Types and casting"
      ]
    SubSection("In conclusion")
    ItemsBlock
      [
          ! @"Graphs offer a powerfull tool for abstracing computation details in favor of high-level transformations."
          ! @"By defining arrows over nodes, interesting properties can be deduced such as composition."
          ! @"Sometimes it is easier to reason in terms of graphs, so in terms of transformations, rather than thinking about actual implementations (see types transformations)."
          ! @"...Next class homomorphisms of graphs that is a structure-preserving map between two algebraic structures (in our case two graphs)"
      ]

//
//    VerticalStack
//      [
//        ItemsBlockWithTitle ""
//          [
//            ! @""
//            ! @""
//        ]
//        ItemsBlockWithTitle ""
//          [
//            ! @""
//            ! @""
//          ]
//      ]
  ]

