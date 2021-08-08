\ Globally used tools
: store-sfarray ( a n -- ) ( r1 ... rn -- )
  swap over 1- sfloats + swap
  0 do dup sf! 1 sfloats - loop drop ;

: sfarray@ ( a n -- ) ( -- r )
  sfloats + sf@ ;

: print-sfarray ( a n -- a )
  0 do dup I sfarray@ f. loop ;


\ vec2 tools
: glm-vec2 ( a -- )  ( f f -- )
  2 store-sfarray ;

: glm-vec2-print ( a -- )
  ." vec2{" 2 print-sfarray ." }" drop ;


\ vec3 tools
: glm-vec3 ( a -- ) ( f f f -- )
  3 store-sfarray ;

: glm-vec3-print ( a -- )
  ." vec3{" 3 print-sfarray ." }" drop ;


\ vec4 tools
\ vec3 tools
: glm-vec4 ( a -- ) ( f f f f -- )
  4 store-sfarray ;

: glm-vec4-print ( a -- )
  ." vec4{" 4 print-sfarray ." }" drop ;
