$("#button").on("click", function () {
        $.ajax({
            type: "Get",
            url: "Update",
            success: function (response) {
                $("#box").empty();
                $.each(response, function (index) {
                    $("#box").append(`<div class="col-lg-4 mb-4">
                            <div class="entry2">
                                <a href="#"><img src="${response[index].ImgPath}" alt="Image" class="img-fluid rounded"></a>
                                <div class="excerpt">
                                    <span class="post-category text-white bg-danger mb-3">В мире</span>
                                    <span class="post-category text-white bg-warning mb-3">Разное</span>
                                    <h2><a href="#">${response[index].Title}</a></h2>
                                    <div class="post-meta align-items-center text-left clearfix">
                                        <figure class="author-figure mb-0 mr-3 float-left"><img src="~/images/person_1.jpg" alt="Image" class="img-fluid"></figure>
                                        <span class="d-inline-block mt-1">By <a href="#">Admi Adminovich</a></span>
                                        <span>&nbsp;-&nbsp; ${response[index].PublicationDate}</span>
                                    </div>

                                    <p>${response[index].Text}</p>
                                    <p><a href="#">Читать далее</a></p>
                                </div>
                            </div>
                        </div>`);
                });
            }
        });
 });   

