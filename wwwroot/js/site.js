// // Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// // for details on configuring this project to bundle and minify static web assets.

// // Write your JavaScript code.
// $(document).ready(function(){
//     // --------------------------- HOME ------------------------
//     // $('.selfie-img').animate({
//     //     opacity: "1"
//     // }, 1000);

//     // if ($(window).width() >= 515){  
//     //     $('.hero-container').hide().slideDown(1000)
//     //     $('.divider').animate({
//     //         width: '+=120%'
//     //     }, 1400)
//     // }
    
//     // --------------------------- ABOUT ------------------------
//     // $('.headshot img').animate({
//     //     opacity: "1"
//     // }, 1000);

//     // ---------------------------------------------------
//     //
//     // -- Nav Bar JavaScript
//     //
//     // ---------------------------------------------------
//     $(window).scroll(function() {
//         if ($(window).scrollTop() > 1) {
//             $(".navbar-container").css({
//                 backgroundColor : "white",
//                 boxShadow : "0px 3px 7px rgb(0, 0, 0, .3)"
//             });
//             $(".desktop-links a").css("color", "#0E1421");
//         } else {
//             $(".navbar-container").css({
//                 backgroundColor : "transparent",
//                 boxShadow : "none"
//             });
//             $(".desktop-links a").css("color", "#ffffff");
            
//         }
//     })

//     if ($(window).width() < 1285) {
//         $(".nav-logo span, .toggle-nav span").css({
//             color : "white"
//         });
//         $(window).scroll(function() {
//             if ($(window).scrollTop() > 1) {
//                 $(".nav-logo span, .toggle-nav span").css({
//                     color : "#0E1421"
//                 })
//             } else {
//                 $(".nav-logo span, .toggle-nav span").css({
//                     color : "#ffffff"
//                 })
//             }
//         });
//     } else {
//         $(".nav-logo span, .toggle-nav span").css({
//             color : "#0E1421"
//         });
//     }

//     $(window).resize(function(){
//         if ($(window).width() < 1285) {
//             $(".nav-logo span, .toggle-nav span").css({
//                 color : "white"
//             })

//             if ($(window).scrollTop() > 1) {
//                 $(".nav-logo span, .toggle-nav span").css({
//                     color : "#0E1421"
//                 })
//             } else {
//                 $(".nav-logo span, .toggle-nav span").css({
//                     color : "#ffffff"
//                 })
//             }

//             $(window).scroll(function() {
//                 if ($(window).scrollTop() > 1) {
//                     $(".nav-logo span, .toggle-nav span").css({
//                         color : "#0E1421"
//                     })
//                 } else {
//                     $(".nav-logo span, .toggle-nav span").css({
//                         color : "#ffffff"
//                     })
//                 }
//             })

//         } else {
//             $(".nav-logo span, .toggle-nav span").css({
//                 color : "#0E1421"
//             })

//             $(window).scroll(function() {
//                 if ($(window).scrollTop() > 1) {
//                     $(".nav-logo span, .toggle-nav span").css({
//                         color : "#0E1421"
//                     })
//                 } else {
//                     $(".nav-logo span, .toggle-nav span").css({
//                         color : "#0E1421"
//                     })
//                 }
//             })
//         }

//     });

//     function openNav() {
//         document.getElementById("myNav").style.height = "100vh"; 
//         $("html").css({
//             "overflow" : "hidden"
//         });
//         $(".mobile-links .toggle-nav").css({
//             "display" : "none"
//         });
//     }

//     function closeNav() {
//         document.getElementById("myNav").style.height = "0vh";
//         $("html").css({
//             "overflow" : "auto"
//         });
//         $(".mobile-links .toggle-nav").css({
//             "display" : "inline-block"
//         });
//     }



//     // ---------------------------------------------------
//     //
//     // -- Landing JavaScript
//     //
//     // ---------------------------------------------------




//     // ---------------------------------------------------
//     //
//     // -- Projects JavaScript
//     //
//     // ---------------------------------------------------
//     class ProjectLightbox {
//         constructor() {
//             this.data = {};
//             this.length = 0;
//             this.initClick();
//             this.initModal();
//         }

//         initClick() {
//             let projects = document.querySelectorAll(".card-container button");
//             for (var i = 0; i < projects.length; i++) {
//                 (function(index){
//                     projects[i].onclick = function(){
//                         openProjectLightBox(index) ;
//                     }    
//                 })(i);
//             }
//         }
//         initModal() {
//             let projectVideo = document.getElementById("project-video");
//             let modal = document.createElement('div');

//             modal.setAttribute("id", "project-modal");
//             modal.classList.add("turn-off-light");

//             let codeBlock = '<div class="modal-content">' + 
//                                 '<span class="close cursor" onclick="closeProjectModal()">&#10005;</span>' +
//                                 '<div id="projectModal"></div>'+
//                             '</div>';
//             modal.innerHTML = codeBlock;
//             projectVideo.insertAdjacentElement("afterend", modal)
//         }
//     }

//     const newProjectLightbox = new ProjectLightbox();
//     let i = 0;

//     function openProjectLightBox(index) {
//         closeNav();
//         i = index;
//         $("html").css({
//             "overflow" : "hidden"
//         })
//         let myModal = document.getElementById("project-modal");
//         let projectModal = document.getElementById("projectModal");
//         let codeBlock = '<video style="width: 100%; object-fit: cover" class="img-thumbnail img-fluid shadow project mb-5" controls>' +
//         '<source src="/assets/uploads/UNTITLED BOT.mp4" type="video/mp4">' +
//         '<source src="/assets/uploads/UNTITLED BOT.mp4" type="video/ogg">' +
//         'Your browser does not support HTML video.' +
//         '</video>';

        
//         projectModal.innerHTML = codeBlock;
//         myModal.classList.remove("turn-off-light");
//         myModal.classList.add("turn-on-light");

//     }

//     function closeProjectModal() {
//         let myModal = document.getElementById("project-modal");

//         myModal.classList.remove("turn-on-light");
//         myModal.classList.add("turn-off-light");
//         $("html").css({
//             "overflow" : "auto"
//         });
//     }




//     // ---------------------------------------------------
//     //
//     // -- About JavaScript
//     //
//     // ---------------------------------------------------




//     // ---------------------------------------------------
//     //
//     // -- Skills JavaScript
//     //
//     // ---------------------------------------------------




//     // ---------------------------------------------------
//     //
//     // -- Connect JavaScript
//     //
//     // ---------------------------------------------------
//     var cw = $('.connect-grid').width() / 2;
//     $('.connect-grid .connect-info').css({'height':cw+'px', "width": cw+"px"});
//     $(".connnect-grid .connect-map").css({
//         "width" : cw+"px",
//         "height" : cw+"px"
//     })

//     if ($(window).width() < 1285) {
//         var cw = $('.connect-grid').width();
//         $('.connect-grid .connect-info').css({
//             'width':cw+'px',
//             'height':cw+"px",
//         });

//     } else {
//         var cw = $('.connect-grid').width() / 2;
//         $('.connect-grid .connect-info').css({'height':cw+'px', "width": cw+"px"});
//         $(".connnect-grid .connect-map").css({
//             "width" : cw+"px",
//             "height" : cw+"px"
//         })
//     }

//     $(window).resize(function(){
//         if ($(window).width() < 1285) {
//             var cw = $('.connect-grid').width();
//             $('.connect-grid .connect-info').css({
//                 'width':cw+'px',
//                 'height':cw+"px",
//             });
//         } else {
//             var cw = $('.connect-grid').width() / 2;
//             $('.connect-grid .connect-info').css({'height':cw+'px', "width": cw+"px"});
//             $(".connnect-grid .connect-map").css({
//                 "width" : cw+"px"
//             })
//         }
//     });

//     if ($(window).width() <= 700) {
//         var cw = $('.connect-grid').width();
//         $('.connect-grid .connect-info').css({
//             'height': "100%",
//         });
//         $('.connect-grid input').css({
//             'width': cw - 100 +"px",
//         });
//         $('.connect-grid button').css({
//             'margin-top': 10 +"px",
//         });
//     }

//     $(window).resize(function(){
//         if ($(window).width() <= 700) {
//             var cw = $('.connect-grid').width();
//             $('.connect-grid .connect-info').css({
//                 'height': "100%",
//             });

//             $('.connect-grid input').css({
//                 'width': cw - 100 +"px",
//             });

//             $('.connect-grid button').css({
//                 'margin-top': 10 +"px",
//             });
//         }
//     });

//     // ---------------------------------------------------
//     //
//     // -- Resume JavaScript
//     //
//     // ---------------------------------------------------
//     class ResumeLightbox {
//         constructor() {
//             this.data = {};
//             this.length = 0;
//             this.initClick();
//             this.initModal();
//         }

//         initClick() {
//             let images = document.getElementsByClassName("resume-btn");
//             for (var i = 0; i < images.length; i++) {
//                 (function(index){
//                     images[i].onclick = function(){
//                         openResumeLightBox(index) ;
//                     }    
//                 })(i);
//             }
//         }
//         initModal() {
//             let resume = document.getElementById("resume");
//             let modal = document.createElement('div');

//             modal.setAttribute("id", "myModal");
//             modal.classList.add("turn-off-light");

//             let codeBlock = '<div class="modal-content">' + 
//                                 '<span class="close cursor" onclick="closeResumeModal()">&#10005;</span>' +
//                                 '<div id="resumeModal"></div>'+
//                             '</div>';
//             modal.innerHTML = codeBlock;
//             resume.insertAdjacentElement("afterend", modal)
//         }
//     }

//     const newLightbox = new ResumeLightbox();
//     let idx = 0;

//     function openResumeLightBox(index) {
//         closeNav();
//         idx = index;
//         $("html").css({
//             "overflow" : "hidden"
//         })
//         let myModal = document.getElementById("myModal");
//         let resumeModal = document.getElementById("resumeModal");
//         let codeBlock = '<div class="mobile-resume container shadow bg-white p-5 mb-5 view-port">' +
//         '<div class="Name mx-auto row mt-3 mx-auto">' +
//         '<h1 class="col-sm-12 col-md-6">Angelo Liwanag</h1>' +
//         '</div>' +
        
//         '<div class="contact row mt-3 mx-auto mb-5">' +
//         '<div class="col-sm-12 col-md-6 extend-view">' +
//                 '<div class="email">' +
//                     '<i class="far fa-envelope text-primary"></i>' +
//                     '<a class="d-inline-block text-secondary">angeloliwanag75@gmail.com</a>' +
//                 '</div>' +
//                 '<div class="location">' +
//                     '<i class="fas fa-map-marker-alt text-primary"></i>' +
//                     '<a class="d-inline-block text-secondary">Long Beach, CA</a>' +
//                 '</div>' +
//             '</div>' +
//             '<div class="col-sm-12 col-md-6 extend-view">' +
//                 '<div class="LinkedIn">' +
//                     '<i class="fab fa-linkedin text-primary"></i>' +
//                     '<a class="d-inline-block text-secondary" target="_blank" href="https://www.linkedin.com/in/angelo-liwanag/">linkedin.com/in/angelo-liwanag</a>' +
//                 '</div>' +
//                 '<div class="GitHub">' +
//                     '<i class="fab fa-github-square text-primary"></i>' +
//                     '<a class="d-inline-block text-secondary" target="_blank" href="https://github.com/AngeloLiwanag\">github.com/AngeloLiwanag</a>' +
//                 '</div>' +
//             '</div>' +
//         '</div>' +

//         '<div class="body-container row mt-4 mx-auto">' +
//             '<div class="col-sm-12 col-md-6 extend-view">' +
//                 '<div class="experience mb-5">' +
//                     '<h3 class="spicy-resume-title">PROFESSIONAL WORK EXPERIENCE</h3>' +
                
//                     '<div class="volatile-studios">' +
//                         '<h5 class="text-primary">Volatile Studios</h5>' +
//                         '<b>Occupation: Associate Web Developer</b>' +
//                         '<b class="d-block"><i class="far fa-calendar-alt"></i>' +
//                         'February 2020 - Present</b>' +
//                         '<div class="m-2">' +
//                             '<p>' +
//                                 'Designed UX/UI wireframes based on 25+ clients’ ideas via Adobe XD and converted into a fully functional responsive prototype that matches the customer’s vision, which resulted in a positive end-user experience' +
//                             '</p>' +
//                             '<p>' +
//                                 'Developed, tested, and deployed responsive web pages through a Custom Management System that manipulates technologies such as HTML5, CSS3, and JavaScript while simultaneously collaborating with back-end developers for any changes in functionality ' +
//                             '</p>' +
//                         '</div>' +
//                     '</div>' +

//                     '<div class="jpmorgan mt-3">' +
//                         '<h5 class="text-primary">JPMorgan Chase & Co.</h5>' +
//                         '<b>Occupation: Software Engineer Virtual Internship</b>' +
//                         '<b class="d-block"><i class="far fa-calendar-alt"></i>' +
//                         'April 2020 - May 2020</b>' +
//                         '<p class="m-2">' +
//                             'Implemented the use of open source code in preparation for data visualization and interaction with stock price data feeds and the use of systems for data analysis' +
//                     '</p>' +
//                         '<p class="m-2">' +
//                             'Utilized the company’s in-house analytics, perspective and contributed to an interface to display an assortment of live and historical data for traders at their workstation' +
//                         '</p>' +
//                     '</div>' +
//                 '</div> ' +
//                 '<div class="projects mb-5">' +
//                     '<h3 class="spicy-resume-title">LIVE PROJECTS</h3>' +
//                     '<div class="bright-event-rentals mt-3">' +
//                         '<h5 class="text-primary">Bright Event Rentals</h5>' +
//                         '<b class="d-block"><i class="far fa-calendar-alt"></i>' +
//                         'August 2020 – December 2020</b>' +
//                         '<p class="m-2">' +
//                             'Drafted and finalized automated global emailing templates for the company’s cart reservations, order payments, and customer service backlogs, which are sent to over 23,000+ clients a year' +
//                         '</p>' +
//                         '<p class="m-2">' +
//                             'Rehabilitated the company’s Instagram API by integrating embedded endpoints from any recent Instagram post to the company’s Custom Management System resulting in an increase in customer engagement' +
//                         '</p>' +
//                     '</div>' +
//                     '<div class="american-rentals mt-3">' +
//                         '<h5 class="text-primary">American Rentals</h5>' +
//                         '<b class="d-block"><i class="far fa-calendar-alt"></i>' +
//                         'March 2020 – July 2020</b>' +
//                         '<p class="m-2">' +
//                             'Assembled a custom-built language translator that converts website content from English to Spanish, leading to an increase in sales and interactions with the Spanish speaking demographic' +
//                         '</p>' +
//                         '<p class="m-2">' +
//                             'Revamped the company’s website from the ground up starting with designing the website’s wireframe, producing a clickable prototype, and finalizing its stage developments' +
//                         '</p>' +
//                     '</div>' +
//                     '<div class="auto-checkout-bot mt-3">' +
//                         '<h5 class="text-primary">Auto-Checkout Bot</h5>' +
//                         '<b class="d-block"><i class="far fa-calendar-alt"></i>' +
//                         'April 2020 – May 2020</b>' +
//                         '<p class="m-2">' +
//                             'Engineered an automated script that allows users to access the Supreme New York website and filter through items dynamically in a matter of 2-3 seconds without any delay or re-captcha' +
//                         '</p>' +
//                         '<p class="m-2">' +
//                             'Generated close to $160 per week throughout Supreme New York’s seasonal drops by marketing auto-checkout slots to the general public'  +
//                         '</p>' +
//                     '</div>' +
//                 '</div>' +
//             '</div>' +
            
//             '<div class="col-sm-12 col-md-6 extend-view">' +
//                 '<div class="tech-skill mb-5">' +
//                     '<h3 class="spicy-resume-title">TECHNICAL SKILLS</h3>' +
//                     '<p><span class="text-primary">Languages:</span> Python, JavaScript, C#, CSS3, HTML5</p>' +
//                     '<p><span class="text-primary">Frameworks/Libraries:</span> Django, Angular, React, Redux, Express.js, Node.js, Mongoose, ASP.NET Core, Bootstrap, Materialize, jQuery</p>' +
//                     '<p><span class="text-primary">Databases:</span> MySQL, NoSQL, MongoDB</p>' +
//                     '<p><span class="text-primary">UX/UI Softwares:</span> AdobeXD, Photoshop</p>' +
//                 '</div>' +
                
//                 '<div class="education mb-5">' +
//                     '<h3 class="spicy-resume-title">EDUCATION</h3>' +
//                     '<div class="CSULB">' +
//                         '<h5 class="text-primary">California State University, Long Beach</h5>' +
//                         '<b class="d-block">Estimated Graduation: Spring 2021</b>' +
//                         '<b>Major: Business Economics</b>' +
//                     '</div>' +
//                     '<div class="coding-dojo mt-3">' +
//                         '<h5 class="text-primary">Coding Dojo, Costa Mesa</h5>' + 
//                         '<b class="d-block"><i class="far fa-calendar-alt"></i> May 2019 - August 2019</b>' +
//                         '<div class="m-2">' +
//                             '<p>Completed an intensive 14 week, full-time web development program, which included the introduction of web fundamentals, implementation of algorithms, and 3 full-stack languages.</p>' +
//                         '</div>' +
//                     '</div>' +
//                 '</div>' +

//                 '<div class="leadership mb-5">' +
//                     '<h3 class="spicy-resume-title">LEADERSHIP</h3>' +
//                     '<div class="zeta-president">' +
//                         '<h5 class="text-primary">Zeta Phi Rho</h5>' +
//                         '<b> Leadership Role: Chapter President</b>' +
//                         '<b class="d-block"><i class="far fa-calendar-alt"></i> May 2019 - Present</b>' +
//                         '<div class="m-2">' +
//                         '<p>Established bi-weekly meetings with the head of the Fraternity Sorority Life Advisor in order to report weekly minutes, and also developed school approved events.</p>' +
//                             '<p>Coordinated regional district chapter meetings to obtain chapter wide Fraternity Liability Insurance, and modified Chapter Bylaws and Policy Procedures.</p>' +
//                         '</div>' +
//                     '</div>' +
//                 '</div>' +

//                 '<div class="interest-hobbies mb-5">' +
//                     '<h3 class="spicy-resume-title">INTEREST & HOBBIES</h3>' +
//                     '<p>Programmer, Breakdancer, Snowboarder, Corgi Dad, Fitness Enthusiast, Marble Macaron Baker</p>' +
//                     '</div>' +
//                 '</div>' +
//             '</div>' +
//         '</div>' +
//     '</div>';
        
//         resumeModal.innerHTML = codeBlock;
//         myModal.classList.remove("turn-off-light");
//         myModal.classList.add("turn-on-light");

//     }

//     function closeResumeModal() {
//         myModal.classList.remove("turn-on-light");
//         myModal.classList.add("turn-off-light");
//         $("html").css({
//             "overflow" : "auto"
//         });
//     }

// });
