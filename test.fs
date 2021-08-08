require cglm.fs

variable vec2test1
variable vec2test2
variable vec2test3
: vec2-test ( -- )
  ." # vec2 test" cr
  \ Allot
  2 sfloats allot here 2 sfloats - vec2test1 !
  2 sfloats allot here 2 sfloats - vec2test2 !
  2 sfloats allot here 2 sfloats - vec2test3 !
  ." * Zeroed vec2: "
  vec2test3 @ glm-vec2-zero
  vec2test3 @ glm-vec2-print cr
  \ Initializing vectors
  2e  5e vec2test1 @ glm-vec2
  10e 4e vec2test2 @ glm-vec2
  ." * Copied vec2: "
  vec2test1 @ vec2test3 @ glm-vec2-copy
  vec2test1 @ glm-vec2-print ."  = "
  vec2test3 @ glm-vec2-print cr
  ." * vec2 sum: "
  vec2test1 @ vec2test2 @ vec2test3 @ glm-vec2-add
  vec2test1 @ glm-vec2-print ."  + "
  vec2test2 @ glm-vec2-print ."  = "
  vec2test3 @ glm-vec2-print cr cr
  \ deallot
  -6 sfloats allot ;

variable vec3test1
variable vec3test2
variable vec3test3
: vec3-test ( -- )
  ." # vec3 test" cr
  \ allot
  3 sfloats dup allot here swap - vec3test1 !
  3 sfloats dup allot here swap - vec3test2 !
  3 sfloats dup allot here swap - vec3test3 !
  ." * Zeroed vec3: "
  vec3test3 @ glm-vec3-zero
  vec3test3 @ glm-vec3-print cr
  \ Initializing vectors
  2e  2e  3e vec3test1 @ glm-vec3
  10e 4e 12e vec3test2 @ glm-vec3
  ." * Copied vec3: "
  vec3test1 @ vec3test3 @ glm-vec3-copy
  vec3test1 @ glm-vec3-print ."  = "
  vec3test3 @ glm-vec3-print cr
  ." * vec3 dot product: "
  vec3test1 @ vec3test2 @ vec3test3 @ glm-vec3-dot
  vec3test1 @ glm-vec3-print ."  . "
  vec3test2 @ glm-vec3-print ."  = "
  f. cr
  ." * vec3 multiplication: "
  vec3test1 @ vec3test2 @ vec3test3 @ glm-vec3-mul
  vec3test1 @ glm-vec3-print ."  * "
  vec3test2 @ glm-vec3-print ."  = "
  vec3test3 @ glm-vec3-print cr
  ." * vec3 cross product: "
  vec3test1 @ vec3test2 @ vec3test3 @ glm-vec3-cross
  vec3test1 @ glm-vec3-print ."  x "
  vec3test2 @ glm-vec3-print ."  = "
  vec3test3 @ glm-vec3-print cr
  ." * vec3 lerp " vec3test1 @ glm-vec3-print ."  => " vec3test2 @ glm-vec3-print cr
  11 0 do
    I s>f 0.1e f* vec3test1 @ vec3test2 @ vec3test3 @ glm-vec3-lerp
    ."   " vec3test3 @ glm-vec3-print ."  (" I 10 * . ." %)" cr
  loop cr
  \ deallot
  -9 sfloats allot ;


variable vec4test1
variable vec4test2
variable vec4test3
: vec4-test ( -- )
  ." # vec4 test" cr
  \ allot
  4 sfloats dup allot here swap - vec4test1 !
  4 sfloats dup allot here swap - vec4test2 !
  4 sfloats dup allot here swap - vec4test3 !
  ." * One'ed vec4: "
  vec4test3 @ glm-vec4-one
  vec4test3 @ glm-vec4-print cr
  \ Initializing vectors
  2e  2e  3e 5e vec4test1 @ glm-vec4
  10e 4e 12e 7e vec4test2 @ glm-vec4
  ." * Copied vec4: "
  vec4test1 @ vec4test3 @ glm-vec4-copy
  vec4test1 @ glm-vec4-print ."  = "
  vec4test3 @ glm-vec4-print cr
  ." * vec4 dot product: "
  vec4test1 @ vec4test2 @ vec4test3 @ glm-vec4-dot
  vec4test1 @ glm-vec4-print ."  . "
  vec4test2 @ glm-vec4-print ."  = "
  f. cr
  ." * vec4 multiplication: "
  vec4test1 @ vec4test2 @ vec4test3 @ glm-vec4-mul
  vec4test1 @ glm-vec4-print ."  * "
  vec4test2 @ glm-vec4-print ."  = "
  vec4test3 @ glm-vec4-print cr
  ." * vec4 normalization: "
  vec4test1 @ vec4test3 @ glm-vec4-copy
  vec4test3 @ glm-vec4-print ."  => "
  vec4test3 @ glm-vec4-normalize
  vec4test3 @ glm-vec4-print cr
  ." * vec4 lerp " vec4test1 @ glm-vec4-print ."  => " vec4test2 @ glm-vec4-print cr
  11 0 do
    I s>f 0.1e f* vec4test1 @ vec4test2 @ vec4test3 @ glm-vec4-lerp
    ."   " vec4test3 @ glm-vec4-print ."  (" I 10 * . ." %)" cr
  loop cr
  \ deallot
  -12 sfloats allot ;



: run ( -- )
  cr vec2-test vec3-test vec4-test ;
