package sep.via.dk.sep3JPA.domain.movie;



import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.Inheritance;
import javax.persistence.InheritanceType;
import javax.persistence.Table;

@Entity
@Table(name = "Movie")
@Inheritance(strategy = InheritanceType.SINGLE_TABLE)

public class Movie{

	@Id
	@GeneratedValue(strategy = GenerationType.AUTO)
	@Column(name = "user_id")
	private Integer id;

	@Column(name = "title", length = 100)
	private String title;

	@Column(name = "director", length = 100)
	private String director;

	@Column(name = "description", length = 2000)
	private String description;

	@Column(name = "duration", length = 50)
	private String duration;

	@Column(name = "urlTrailer", length = 1000)
	private String urlTrailer;

	@Column(name = "urlFullMovie", length = 1000)
	private String urlFullMovie;

	@Column(name = "urlImage", length = 2000)
	private String urlImage;

	@Column(name = "category", length = 20)
	private String category;

	public Movie() {

	}

	public String getCategory() {
		return category;
	}

	public void setCategory(String category) {
		this.category = category;
	}

	public Movie(String name, String director, String description, String duration, String urlTrailer,
			String urlFullMovie, String urlImage, String category) {
		this.title = name;
		this.director = director;
		this.description = description;
		this.duration = duration;
		this.urlTrailer = urlTrailer;
		this.urlFullMovie = urlFullMovie;
		this.urlImage = urlImage;
		this.category = category;
	}

	public String getTitle() {
		return title;
	}

	public void setTitle(String name) {
		this.title = name;
	}

	public String getDirector() {
		return director;
	}

	public void setDirector(String director) {
		this.director = director;
	}

	public String getDescription() {
		return description;
	}

	public void setDescription(String discription) {
		this.description = discription;
	}

	public String getDuration() {
		return duration;
	}

	public void setDuration(String duration) {
		this.duration = duration;
	}

	public String getUrlTrailer() {
		return urlTrailer;
	}

	public void setUrlTrailer(String urlTrailer) {
		this.urlTrailer = urlTrailer;
	}

	public String getUrlFullMovie() {
		return urlFullMovie;
	}

	public void setUrlFullMovie(String urlFullMovie) {
		this.urlFullMovie = urlFullMovie;
	}

	public String getUrlImage() {
		return urlImage;
	}

	public void setUrlImage(String urlImage) {
		this.urlImage = urlImage;
	}

	public Integer getId() {
		return id;
	}

	public void setId(Integer id) {
		this.id = id;
	}

	

}