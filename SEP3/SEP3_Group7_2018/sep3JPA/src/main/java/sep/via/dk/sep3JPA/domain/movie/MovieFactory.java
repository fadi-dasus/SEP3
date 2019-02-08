package sep.via.dk.sep3JPA.domain.movie;





public class MovieFactory {

	

	public MovieFactory() {
		
	}

	public static Movie create(String title, String director, String description, String category,
			String duration, String urlTrailer, String urlFullMovie, String urlImage) {

		Movie movie = null;

		switch (category) {
		case "Action":
			movie = new ActionMovie(title, director, description, duration, urlTrailer, urlFullMovie, urlImage,
					"Action");
			break;
		case "Crime":
			movie = new ActionMovie(title, director, description, duration, urlTrailer, urlFullMovie, urlImage,
					"Crime");
			break;
		case "Adventure":
			movie = new AdventureMovie(title, director, description, duration, urlTrailer, urlFullMovie, urlImage,
					"Adventure");
			break;
		case "Comedy":
			movie = new ComedyMovie(title, director, description, duration, urlTrailer, urlFullMovie, urlImage,
					"Comedy");
			break;

		case "Drama":
			movie = new DramaMovie(title, director, description, duration, urlTrailer, urlFullMovie, urlImage, "Drama");
			break;
		case "Horror":
			movie = new HorrorMovie(title, director, description, duration, urlTrailer, urlFullMovie, urlImage,
					"Horror");
			break;
		default:
			movie = new ActionMovie(title, director, description, duration, urlTrailer, urlFullMovie, urlImage,
					"Action");
			break;
		}

		return movie;
	}
}