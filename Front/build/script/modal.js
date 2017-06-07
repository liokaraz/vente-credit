$(".btn-info-2").on('click', function() {
  TweenMax.fromTo(".modal", 0.5, 
    {
      display: "none",
      opacity: 0
    },
    {
      display: "block",
      opacity:1
    }
  );
  TweenMax.fromTo(".modal-background", 0.5, 
    {
      display: "none",
      opacity: 0
    },
    {
      display: "block",
      opacity: 0.5
    }
  );
});

$(".modal-background").on('click', function() {
  TweenMax.fromTo(".modal", 0.5, 
    {
      display: "block",
      opacity: 1
    },
    {
      display: "none",
      opacity: 0
    }
  );
  TweenMax.fromTo(".modal-background", 0.5, 
    {
      display: "block",
      opacity: 0.5
    },
    {
      display: "none",
      opacity: 0
    }
  );
});

$(".btn-close").on('click', function() {
  TweenMax.fromTo(".modal", 0.5, 
    {
      display: "block",
      opacity: 1
    },
    {
      display: "none",
      opacity: 0
    }
  );
  TweenMax.fromTo(".modal-background", 0.5, 
    {
      display: "block",
      opacity: 0.5
    },
    {
      display: "none",
      opacity: 0
    }
  );
});