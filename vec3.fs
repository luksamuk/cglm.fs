c-function glm-vec3-copy     glm_vec3_copy     a a -- void
c-function glm-vec3-zero     glm_vec3_zero     a -- void
c-function glm-vec3-one      glm_vec3_one      a -- void
c-function glm-vec3-dot      glm_vec3_dot      a a -- r
c-function glm-vec3-norm2    glm_vec3_norm2    a -- r
c-function glm-vec3-norm     glm_vec3_norm     a -- r
c-function glm-vec3-norm-one glm_vec3_norm_one a -- r
c-function glm-vec3-norm-inf glm_vec3_norm_inf a -- r
c-function glm-vec3-add      glm_vec3_add      a a a -- void
c-function glm-vec3-adds     glm_vec3_adds     a r a -- void
c-function glm-vec3-sub      glm_vec3_sub      a a a -- void
c-function glm-vec3-subs     glm_vec3_subs     a r a -- void
c-function glm-vec3-mul      glm_vec3_mul      a a a -- void
c-function glm-vec3-scale    glm_vec3_scale    a r a -- void
c-function glm-vec3-scale-as glm_vec3_scale_as a r a -- void
c-function glm-vec3-div      glm_vec3_div      a a a -- void
c-function glm-vec3-divs     glm_vec3_divs     a r a -- void
c-function glm-vec3-addadd   glm_vec3_addadd   a a a -- void
c-function glm-vec3-subadd   glm_vec3_subadd   a a a -- void
c-function glm-vec3-muladd   glm_vec3_muladd   a a a -- void
c-function glm-vec3-muladds  glm_vec3_muladds  a r a -- void
c-function glm-vec3-maxadd   glm_vec3_maxadd   a a a -- void
c-function glm-vec3-minadd   glm_vec3_minadd   a a a -- void
c-function glm-vec3-flipsign glm_vec3_flipsign a -- void
c-function glm-vec3-flipsign-to glm_vec3_flipsign_to a a -- void
c-function glm-vec3-negate-to glm_vec3_negate_to a a -- void
c-function glm-vec3-negate   glm_vec3_negate   a -- void
c-function glm-vec3-inv      glm_vec3_inv      a -- void
c-function glm-vec3-inv-to   glm_vec3_inv_to   a a -- void
c-function glm-vec3-normalize glm_vec3_normalize a -- void
c-function glm-vec3-normalize-to glm_vec3_normalize_to a a -- void
c-function glm-vec3-cross    glm_vec3_cross    a a a -- void
c-function glm-vec3-crossn   glm_vec3_crossn   a a a -- void
c-function glm-vec3-angle    glm_vec3_angle    a a -- r
c-function glm-vec3-rotate   glm_vec3_rotate   a r a -- void
c-function glm-vec3-rotate-m4 glm_vec3_rotate_m4 a a a -- void
c-function glm-vec3-rotate-m3 glm_vec3_rotate_m3 a a a -- void
c-function glm-vec3-proj      glm_vec3_proj    a a a -- void
c-function glm-vec3-center    glm_vec3_center  a a a -- void
c-function glm-vec3-distance2 glm_vec3_distance2 a a -- r
c-function glm-vec3-distance glm_vec3_distance a a -- r
c-function glm-vec3-maxv     glm_vec3_maxv     a a a -- void
c-function glm-vec3-minv     glm_vec3_minv     a a a -- void
c-function glm-vec3-ortho    glm_vec3_ortho    a a -- void
c-function glm-vec3-clamp    glm_vec3_clamp    a r r -- void
c-function glm-vec3-lerp     glm_vec3_lerp     a a r a -- void
c-function glm-vec3-lerpc    glm_vec3_lerpc    a a r a -- void
c-function glm-vec3-mix      glm_vec3_mix      a a r a -- void
c-function glm-vec3-mixc     glm_vec3_mixc     a a r a -- void
c-function glm-vec3-step-uni glm_vec3_step_uni r a a -- void
c-function glm-vec3-step     glm_vec3_step     a a a -- void
c-function glm-vec3-smoothstep-uni glm_vec3_smoothstep_uni r r a a -- void
c-function glm-vec3-smoothstep glm_vec3_smoothstep a a a a -- void
c-function glm-vec3-smoothinterp glm_vec3_smoothinterp a a r a -- void
c-function glm-vec3-smoothinterpc glm_vec3_smoothinterpc a a r a -- void
c-function glm-vec3-swizzle  glm_vec3_swizzle  a n a -- void


\ Convenient aliases
c-function glm-cross         glm_cross         a a a -- void
c-function glm_dot           glm_dot           a a -- r
c-function glm-normalize     glm_normalize     a -- void
c-function glm-normalize-to  glm_normalize_to  a a -- void

