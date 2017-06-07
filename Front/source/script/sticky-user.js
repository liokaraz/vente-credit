var stickyState = 0;
$(".nav__menu-user").on('click', function() {
  if (stickyState == 1) {
    stickyState = 0;
    TweenMax.fromTo(".sticky-user", 0.3, 
      {
        display: "block", 
        opacity: 1, 
        top: "60px"
      },
      {
        display:"none",
        opacity:0,
        top: "40px"
      }
    );
    return null;
  }
  if (stickyState == 0) {
    stickyState = 1;
    TweenMax.fromTo(".sticky-user", 0.3, 
      {
        display: "none", 
        opacity: 0, 
        top: "40px"
      },
      {
        display:"block",
        opacity:1,
        top: "60px"
      }
    );
  }
  return null;
});