(function ($) {
  'use strict';
  $(function () {
    var sidebar = $('.mdc-drawer-menu');
    var body = $('body');

    if($('.mdc-drawer').length) {
      var drawer = mdc.drawer.MDCDrawer.attachTo(document.querySelector('.mdc-drawer'));
      // toggler icon click function
      document.querySelector('.sidebar-toggler').addEventListener('click', function () {
        drawer.open = !drawer.open;
      });
    }

    // Initially collapsed drawer in below desktop
    if(window.matchMedia('(max-width: 991px)').matches) {
      if(document.querySelector('.mdc-drawer.mdc-drawer--dismissible').classList.contains('mdc-drawer--open')) {
        document.querySelector('.mdc-drawer.mdc-drawer--dismissible').classList.remove('mdc-drawer--open'); 
      }
    }

    //Add active class to nav-link based on url dynamically
    //Active class can be hard coded directly in html file also as required
    //var current = location.pathname.split("/").slice(-1)[0].replace(/^\/|\/$/g, '');
    //$('.mdc-drawer-item .mdc-drawer-link', sidebar).each(function () {
    //  var $this = $(this);
    //  if (current === "") {
    //    //for root url
    //    if ($this.attr('href').indexOf("Index") !== -1) {
    //      $(this).addClass('active');
    //      if ($(this).parents('.mdc-expansion-panel').length) {
    //        $(this).closest('.mdc-expansion-panel').addClass('expanded');
    //      }
    //    }
    //  } else {
    //    //for other url
    //    if ($this.attr('href').indexOf(current) !== -1) {
    //      $(this).addClass('active');
    //      if ($(this).parents('.mdc-expansion-panel').length) {
    //        $(this).closest('.mdc-expansion-panel').addClass('expanded'); 
    //        $(this).closest('.mdc-expansion-panel').show();
    //      }
    //    }
    //  }
      //});
      if (window.location.href.toLowerCase().includes("sales") && window.location.href.toLowerCase().includes("completedsales") == false) {
          $('.dropDown').first().addClass("active");
          $('.dropDown').first().closest('.mdc-expansion-panel').show();
      } else if (window.location.href.toLowerCase().includes("sales") && window.location.href.toLowerCase().includes("completedsales")) {
          $('.dropDown').last().addClass("active")
          $('.dropDown').last().closest('.mdc-expansion-panel').show();


      }

    // Toggle Sidebar items
    $('[data-toggle="expansionPanel"]').on('click', function () {
      // close other items
      $('.mdc-expansion-panel').not($('#' + $(this).attr("data-target"))).hide(300);
      $('.mdc-expansion-panel').not($('#' + $(this).attr("data-target"))).prev('[data-toggle="expansionPanel"]').removeClass("expanded");
      // Open toggle menu
      $('#' + $(this).attr("data-target")).slideToggle(300, function() {
        $('#' + $(this).attr("data-target")).toggleClass('expanded');
      });
    });


    // Add expanded class to mdc-drawer-link after expanded
    $('.mdc-drawer-item .mdc-expansion-panel').each(function () {
      $(this).prev('[data-toggle="expansionPanel"]').on('click', function () {
        $(this).toggleClass('expanded');
      })
    });

    //Applying perfect scrollbar to sidebar
    if (!body.hasClass("rtl")) {
      if ($('.mdc-drawer .mdc-drawer__content').length) {
        const chatsScroll = new PerfectScrollbar('.mdc-drawer .mdc-drawer__content');
      }
    }
      // Search Start
      $("#searchBtn").click(function () {
          $(".search-box").css("transition", "0.6s ease-in")
          $(".search-box").css("border-radius", "40px")
          $(".search-box").css("background", "turquoise")
          $("#searchBtn").css("opacity", "0")

          setTimeout(function Width() {
              $(".search-box").css("width", "320px")
          }, 600)
          setTimeout(function CloseBtn() {
              $("#closeBtn").css("display", "block")
          }, 600)
          setTimeout(function CloseBtn() {
              $("#closeBtn").css("opacity", "1")
          }, 1200)
          setTimeout(function SearchBtn() {
              $("#searchBtn").css("display", "none")
          }, 600)
          setTimeout(function Form() {
              $("#Search #form").css("display", "flex")
          }, 600)
          setTimeout(function Form() {
              $("#Search #form").css("opacity", "1")
          }, 1200)
          $(".search-box").css("transform", "rotateZ(360deg)")
      })
      $("#closeBtn").click(function () {
          // $(".search-box").css("transition", "0.6s ease-in")
          // $(".search-box").css("border-radius", "50px")
          // $(".search-box").css("background", "#236bdf")
          $("#closeBtn").css("opacity", "0")
          $("#Search #form").css("opacity", "0")
          // $("#searchBtn").css("opacity", "1")


          setTimeout(function Width() {
              $(".search-box").css("width", "50px")
          }, 100)
          setTimeout(function CloseBtn() {
              $("#closeBtn").css("display", "none")
              $("#Search .search-txt").val("")

          }, 600)
          setTimeout(function SearchBtn() {
              $("#searchBtn").css("display", "block")
          }, 600)
          setTimeout(function SearchBtn() {
              $("#searchBtn").css("opacity", "1")
          }, 700)
          setTimeout(function Form() {
              $("#Search #form").css("display", "none")
          }, 800)
          setTimeout(function SearchBtn() {
              $(".search-box").css("transform", "rotateZ(-360deg)")
              $(".search-box").css("border-radius", "0px")
              $(".search-box").css("background", "#236bdf")
          }, 700)
      })
      $("#Search #form .search-txt.books").keyup(function () {
          let search = $(this).val();
          $("#Search #form ul li").not($("#Search #form ul li").first()).remove();
          if (search.length > 0 && search.trim() != "") {
              $.ajax({
                  url: "/BakumozAdminPanel/Books/Search?search=" + search,
                  type: "Get",
                  success: function (res) {
                      $("#Search #form ul").append(res);
                  }
              })
          }

      })
      $("#Search #form .search-txt.publishers").keyup(function () {
          let search = $(this).val();
          $("#Search #form ul li").not($("#Search #form ul li").first()).remove();
          if (search.length > 0 && search.trim() != "") {
              $.ajax({
                  url: "/BakumozAdminPanel/Publishers/Search?search=" + search,
                  type: "Get",
                  success: function (res) {
                      $("#Search #form ul").append(res);
                  }
              })
          }

      })
    // Search End
  });
})(jQuery);