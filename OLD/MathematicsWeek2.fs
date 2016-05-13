
module MathematicsWeek2

open CommonLatex
open LatexDefinition
open CodeDefinitionLambda
open Interpreter


let slides =
  [
    Section("Functions")

    SubSection("Specification")
    ItemsBlock
      [
          ! @"A function $f$ is a mathematical entity with the following attributes:"
          ! @"[F-1] $f$ has a \textbf{domain} and a \textbf{codomain}, each of which be a set."
          ! @"[F-2] For every element $x$ of the domain, $f$ has a \textbf{value} at $x$, which is an element  of the codomain and is denoted $f(x)$."
          ! @"[F-3] The domain, the codomain, and the value $f(x)$ for each $x$ in the domain are all determined completely by the function."
          ! @"[F-4] Conversely, the data consisting of the domain, the codomain, and the value $f(x)$ for each element $x$ of the domain completely determine the function $f$."
      ]


    VerticalStack
      [
        ItemsBlockWithTitle "Arrow notation"
          [
            ! @"$f : S \longrightarrow T$ is a succint way of saying that the function $f$ has domain $S$ and codomain $T$. It could also be read as `Let $f$ be a function from $S$ to $T$'."
            ! @"One also says that $f$ is of type `$S$ arrow $T$'."
        ]
        ItemsBlockWithTitle "Barred arrow notation"
          [
            ! @"Used to provide an anonymous notation for functions. For example the function from $\mathbb{R}$ to $\mathbb{R}$ that squares its input can be denoted $x \longmapsto x^2 : \mathbb{R} \longrightarrow \mathbb{R}$."
            ! @"The barred arrow goes from data to da, whereas the long arrow goes from domain to codomain."
          ]
      ]

    SubSection("Examples of functions")
    ItemsBlock
      [
          ! @"[(i)] $x \longmapsto x^2 : \mathbb{R} \longrightarrow \mathbb{R^+}$"
          ! @"[(ii)] $x \longmapsto x^2 : \mathbb{R} \longrightarrow \mathbb{R}$"
          ! @"[(iii)] $x \longmapsto x^2 : \mathbb{R^+} \longrightarrow \mathbb{R^+}$"
          ! @"[(iv)] $x \longmapsto x^2 : \mathbb{R^+} \longrightarrow \mathbb{R}$"
      ]

    SubSection("The graph of a function")
    ItemsBlock
      [
          ! @"$f : S \longrightarrow T$ is the set of ordered pairs: $\{ (x,f(x)) | x \in S \}$."
          ! @"The graph of a function from $S$ to $T$ is a relation from $S$ to $T$ with the restriction that it must have the \textbf{functional property} that for all $s \in S$, there is one and only one $t \in T$ such that $(s,t)$ is in the graph."
      ]

    SubSection("The image of a function")
    ItemsBlock
      [
          ! @"Is its set of values; that is, the image of $f : S \longrightarrow T$ is $\{ t \in T | \exists s \in S \, \text{for which } f(s) = t \}$."
          ! @"The image of the previous example is the set of non-negative reals."
      ]

    VerticalStack
      [
        ItemsBlockWithTitle "Injective (one-to-one)"
          [
            ! @"A function $f : S \longrightarrow T$ is \textbf{injective} if whenever $s \neq s'$ in $S$, then $f(s) \neq f(s')$ in $T$."
        ]
        ItemsBlockWithTitle "Example"
          [
            ! @"The function $x \longmapsto x^2 : \mathbb{R} \longrightarrow \mathbb{R}$ is not injective since it takes $2$ and $-2$ and returns the same value, namely $4$."
            ! @"On the other hand  $x \longmapsto x^3 : \mathbb{R} \longrightarrow \mathbb{R}$ is injective."
          ]
      ]
    VerticalStack
      [
        ItemsBlockWithTitle "Surjective"
          [
            ! @"A function $f : S \longrightarrow T$ if its image is $T$."
            ! @""
        ]
        ItemsBlockWithTitle "Examples"
          [
            ! @"The identity function is a surjective function."
            ! @"$x \longmapsto x^2 : \mathbb{R} \longrightarrow \mathbb{R^+}$ is a surjective function."
            ! @"$x \longmapsto x^2 : \mathbb{R^+} \longrightarrow \mathbb{R^+}$ is a surjective function."
          ]
        ItemsBlockWithTitle "Bijective"
          [
            ! @"A function is bijective if it is surjective and injective. It is also \textbf{called one to one correspondence}."
          ]
      ]

    SubSection("Coordinate functions")
    ItemsBlock
      [
          ! @"If $S$ and $T$ are sets, the cartesian product $S \times T$ is equipped with two \textbf{coordinate} or \textbf{projection} functions $proj_1 : S \times \T \longrightarrow S$ and  $proj_2 : S \times \T \longrightarrow T$."
          ! @"The coordinate functions are surjective if $S$ and $T$ are both nonempty."
      ]

    SubSection("Notation - $\langle f,g \\rangle$ ")
    ItemsBlock
      [
          ! @"If $X, S$ and $T$ are sets, and $f : X \longrightarrow S$ and $g : X \longrightarrow T$ are functions, then the function $\langle f,g \rangle : X \longrightarrow S \times T$ is defined by $\langle f,g \rangle (x) = (f(x),g(x))$ for all $x \in X$"
      ]

    SubSection("Cartesian product")
    ItemsBlock
      [
          ! @"If $X, Y, S$ and $T$ are sets, and $f : X \longrightarrow S$ and $g : Y \longrightarrow T$ are functions, then the function $f \ times g : X \times  Y \longrightarrow S \times T $ is defined by $(f,g) (x,y) = (f(x),g(y))$"
          ! @"It is called the \textbf{cartesian product} of the functions $f$ and $g$."
      ]


    SubSection("Composite function")
    ItemsBlock
      [
          ! @"If $f : S \longrightarrow T$ and $g : T \longrightarrow U$, then the \textbf{composite} function $g \circ f : S \longrightarrow U$ is defined to be the unique function with domain $S$ and codomain $U$ for which $(g \circ f)(x) = g(f(x))$ for all $x \in S$." 
          ! @"In computer science literatures $f;g$ is often used for $g \circ f$" 
          ! @"It is neccessay to insist that the codomain of $f$ be the domain of $g$ for the composite $g \circ f$ to be defined"
      ]

    SubSection("Restriction")
    ItemsBlock
      [
          ! @"If $f : S \longrightarrow T$ and $A \subseteq S$, then the \textbf{restriction} of $f$ to $A$ is the composity $f \circ i$, where $i : A \longrightarrow S$ is the inclusion function." 
          ! @"The square squaring function in $x \longmapsto x^2 : \mathbb{R^+} \longrightarrow \mathbb{R^+}$ is the restriction to $\mathbb{R^+}$ of the squaring function in $x \longmapsto x^2 : \mathbb{R} \longrightarrow \mathbb{R^+}$"
      ]

    SubSection("Functions in theory and practice")
    ItemsBlock
      [
          ! @"The concept of a function can be explicitly defined in terms of its domain, codomain, and graph." 
          ! @"Precisely, a function $f : S \longrightarrow T$ could be defined as an ordered triple $(S,\Gamma,T)$ with the property that $\Gamma$ is a subset of the cartesian $S \times T$ with the functional property ($\Gamma$ is the graph of $f$). " 
          ! @"For $x \in S, f(x)$ is the unique element $y \in T$ for which $(x,y) \in \Gamma$" 
      ]

    SubSection("Homomorphism")
    ItemsBlock
      [
          ! @"Let $S$ and $T$ e sets, and let $Hom(S,T)$ denote the set of all functions with domain $S$ and codomain $T$. Let $f : T \longrightarrow V$ be a function. The function"
          ! @"[]\centering $Hom(S, f) : Hom(S, T) \longrightarrow Hom(S, V)$" 
          ! @"[]\flushleft is defined by"  
          ! @"[]\centering $Hom(S,f)(g) = f \circ g$"  
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

