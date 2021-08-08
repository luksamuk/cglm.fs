require cglm.fs

vec2 v2a
vec2 v2b
vec2 v2d

vec3 v3a
vec3 v3b
vec3 v3d

vec4 v4a
vec4 v4b
vec4 v4d

: vec2-test ( -- )
  ." # vec2 test" cr
  ." * Zeroed vec2: "
  v2d glm-vec2-zero
  v2d glm-vec2-print cr
  \ Initializing vectors
  2e  5e v2a glm-vec2
  10e 4e v2b glm-vec2
  ." * Copied vec2: "
  v2a v2d glm-vec2-copy
  v2a glm-vec2-print ."  = "
  v2d glm-vec2-print cr
  ." * vec2 sum: "
  v2a v2b v2d glm-vec2-add
  v2a glm-vec2-print ."  + "
  v2b glm-vec2-print ."  = "
  v2d glm-vec2-print cr cr ;

: vec3-test ( -- )
  ." # vec3 test" cr
  ." * Zeroed vec3: "
  v3d glm-vec3-zero
  v3d glm-vec3-print cr
  \ Initializing vectors
  2e  2e  3e v3a glm-vec3
  10e 4e 12e v3b glm-vec3
  ." * Copied vec3: "
  v3a v3d glm-vec3-copy
  v3a glm-vec3-print ."  = "
  v3d glm-vec3-print cr
  ." * vec3 dot product: "
  v3a v3b v3d glm-vec3-dot
  v3a glm-vec3-print ."  . "
  v3b glm-vec3-print ."  = "
  f. cr
  ." * vec3 multiplication: "
  v3a v3b v3d glm-vec3-mul
  v3a glm-vec3-print ."  * "
  v3b glm-vec3-print ."  = "
  v3d glm-vec3-print cr
  ." * vec3 cross product: "
  v3a v3b v3d glm-vec3-cross
  v3a glm-vec3-print ."  x "
  v3b glm-vec3-print ."  = "
  v3d glm-vec3-print cr
  ." * vec3 lerp " v3a glm-vec3-print ."  => " v3b glm-vec3-print cr
  11 0 do
    I s>f 0.1e f* v3a v3b v3d glm-vec3-lerp
    ."   " v3d glm-vec3-print ."  (" I 10 * . ." %)" cr
  loop drop cr ;


: vec4-test ( -- )
  ." # vec4 test" cr
  ." * One'ed vec4: "
  v4a glm-vec4-one
  v4a glm-vec4-print cr
  \ Initializing vectors
  2e  2e  3e 5e v4a glm-vec4
  10e 4e 12e 7e v4b glm-vec4
  ." * Copied vec4: "
  v4a v4d ~~ glm-vec4-copy
  v4a glm-vec4-print ."  = "
  v4d glm-vec4-print cr
  ." * vec4 dot product: "
  v4a v4b v4d glm-vec4-dot
  v4a glm-vec4-print ."  . "
  v4b glm-vec4-print ."  = "
  f. cr
  ." * vec4 multiplication: "
  v4a v4b v4d glm-vec4-mul
  v4a glm-vec4-print ."  * "
  v4b glm-vec4-print ."  = "
  v4d glm-vec4-print cr
  ." * vec4 normalization: "
  v4a v4d glm-vec4-copy
  v4d glm-vec4-print ."  => "
  v4d glm-vec4-normalize
  v4d glm-vec4-print cr
  ." * vec4 lerp " v4a glm-vec4-print ."  => " v4b glm-vec4-print cr
  11 0 do
    I s>f 0.1e f* v4a v4b v4d glm-vec4-lerp
    ."   " v4d glm-vec4-print ."  (" I 10 * . ." %)" cr
  loop drop cr ;



: run ( -- )
  cr vec2-test ~~ vec3-test ~~ vec4-test ~~ ;
