　$(function(){
    　　$('.tree li:has(ul)').addClass('parent_li').find(' > span').attr('title', 'Collapse this branch');
    　　$('.tree li.parent_li > span').on('click', function (e) {
       　　 var children = $(this).parent('li.parent_li').find(' > ul > li');
        　　if (children.is(":visible")) {
            　　children.hide('fast');
            　　$(this).attr('title', 'Expand this branch').find(' > i').addClass('icon-plus-sign').removeClass('icon-minus-sign');
        　　} else {
            　　children.show('fast');
            　　$(this).attr('title', 'Collapse this branch').find(' > i').addClass('icon-minus-sign').removeClass('icon-plus-sign');
        　　}
        　　e.stopPropagation();
    　　});    
　　});
		

		window.addEventListener('load', function() {
//		    console.log(window.innerWidth);
		    if(window.innerWidth<=995)
			    {
			    	$("#rightbox").css("display","none");
			    	$("#content").removeClass("col-sm-6");
			    	$("#content").addClass("col-sm-9");
			    	$("#leftbox1").css("display","none");
			    	$("#leftbox").removeClass("this-left-nav");
			    	$("#leftbox").removeClass("col-sm-2");
				    $("#leftbox").addClass("col-sm-3");
			    }
			    if(window.innerWidth<=930)
			    {
			    	//$("#leftbox").css("display","none");
			    	$("#leftbox").removeClass("col-sm-3");
				    $("#leftbox").addClass("col-sm-12");
			    	$("#content").removeClass("col-sm-9");
			    	$("#content").removeClass("this-content");
			    	$("#content").addClass("col-sm-12");
			    }
			    if(window.innerWidth>995)
			    {
			    	$("#rightbox").css("display","");
			    	$("#leftbox1").css("display","");
			    	$("#content").removeClass("col-sm-9");
			    	$("#content").addClass("col-sm-6");
			    	$("#leftbox").addClass("this-left-nav");
			    	$("#leftbox").removeClass("col-sm-3");
				    $("#leftbox").addClass("col-sm-2");
				    $("#content").addClass("this-content");
			    }
			    if(window.innerWidth>930)
			    {
			    	$("#leftbox").removeClass("col-sm-12");
				    $("#leftbox").addClass("col-sm-3");
			    	$("#content").removeClass("col-sm-12");
			    	$("#content").addClass("col-sm-9");
			    	$("#content").addClass("this-content");
			    }
		    window.addEventListener('resize', function() {
//		        console.log(window.innerWidth);
		         if(window.innerWidth<=995)
			    {
			    	$("#rightbox").css("display","none");
			    	$("#content").removeClass("col-sm-6");
			    	$("#content").addClass("col-sm-9");
			    	$("#leftbox1").css("display","none");
			    	$("#leftbox").removeClass("this-left-nav");
			    	$("#leftbox").removeClass("col-sm-2");
				    $("#leftbox").addClass("col-sm-3");
			    }
			    if(window.innerWidth<=930)
			    {
			    	//$("#leftbox").css("display","none");
			    	$("#leftbox").removeClass("col-sm-3");
				    $("#leftbox").addClass("col-sm-12");
			    	$("#content").removeClass("col-sm-9");
			    	$("#content").removeClass("this-content");
			    	$("#content").addClass("col-sm-12");
			    }
			    if(window.innerWidth>995)
			    {
			    	$("#rightbox").css("display","");
			    	$("#leftbox1").css("display","");
			    	$("#content").removeClass("col-sm-9");
			    	$("#content").addClass("col-sm-6");
			    	$("#leftbox").addClass("this-left-nav");
			    	$("#leftbox").removeClass("col-sm-3");
				    $("#leftbox").addClass("col-sm-2");
				    $("#content").addClass("this-content");
			    }
			    if(window.innerWidth>930)
			    {
			    	$("#leftbox").removeClass("col-sm-12");
				    $("#leftbox").addClass("col-sm-3");
			    	$("#content").removeClass("col-sm-12");
			    	$("#content").addClass("col-sm-9");
			    	$("#content").addClass("this-content");
			    }
		    })
		
		})

