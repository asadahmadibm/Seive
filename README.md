# Seive
sorting, filtering, and pagination 
  کتابخانه .net که sorting, filtering, and pagination را سمت سرور پیاده سازی مینماید

## نحوه استفاده:

      1-	add the Sieve NuGet package
      2-	register in Program.cs : builder.Services.AddScoped<ISieveProcessor, SieveProcessor>();
      3-	use Sieve attribute for each property : 
      [Sieve(CanSort = true)]
      [Sieve(CanFilter = true)]
      [Sieve(CanSort = true, CanFilter = true)]
      4-	in an HTTP GET method, pass the SieveModel class as a parameter :
      [HttpGet]
              public IActionResult GetShoes([FromQuery] SieveModel sieveModel)
              {
                  var result = _sieveProcessor.Apply(sieveModel, _shoeRetrievalService.GetShoes());
                  return Ok(result);
              }
  ## Send a request :
      GET /GetPosts
      ?sorts=     LikeCount,CommentCount,-created          
      &filters=   LikeCount>10, Title@=awesome title,     
      &page=      1                                       // get the first page...
      &pageSize=  10
      
      نمونه ارسال پارامتر :
      /api/shoes?sorts=Price,-Rating
      /api/shoes?filters=Brand@=Nike
      /api/shoes?filters=Brand@=Nike&sorts=Rating
      /api/shoes?pageSize=1&page=2
##       جهت customize  کردن داریم :

      1-	appsettings.json  :
      	"Sieve": {
             		 "CaseSensitive": false,
      "DefaultPageSize":  2 
          		}
      2-	in program.cs :
      builder.Services.Configure<SieveOptions>(builder.Configuration.GetSection("Sieve"));

## منابع : 
https://github.com/Biarity/Sieve

https://code-maze.com/dotnet-sorting-filtering-pagination-sieve-package/

