package sep.via.dk.sep3JPA.domain;

import java.time.LocalDate;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.Table;

import com.fasterxml.jackson.annotation.JsonFormat;

import sep.via.dk.sep3JPA.domain.movie.Movie;

@Entity
@Table(name = "Ticket")
public class Ticket {

	

	@Id
	@GeneratedValue(strategy = GenerationType.AUTO)
	private Integer id;

	@ManyToOne
	@JoinColumn(name = "movie_id")
	private Movie movie;

	@Column(name = "firstName", nullable = false)
	private String firstName;

	@Column(name = "lastName")
	private String lastName;

	
	@Column(name = "movieDate")
	private String movieDate;

	@JsonFormat(shape = JsonFormat.Shape.STRING, pattern = "yyyy-MM-dd")
	@Column(name = "issuingDate")
	private LocalDate issuingDate;

	@Column(name = "time")
	private String time;

	@Column(name = "dateOfBirth")
	private String dateOfBirth;

	public Ticket() {

	}

	public Ticket(Integer id, String firstName, String lastName, String movieDate, String time, String dateOfBirth,
			Movie movie) {
		this.issuingDate = LocalDate.now();
		this.id = id;
		this.firstName = firstName;
		this.lastName = lastName;
		this.movieDate = movieDate;
		this.time = time;
		this.dateOfBirth = dateOfBirth;
		this.movie = movie;
	}

	public Integer getId() {
		return id;
	}

	public void setId(Integer id) {
		this.id = id;
	}

	public String getFirstName() {
		return firstName;
	}

	public void setFirstName(String firstName) {
		this.firstName = firstName;
	}

	public String getLastName() {
		return lastName;
	}

	public void setLastName(String lastName) {
		this.lastName = lastName;
	}

	public String getMovieDate() {
		return movieDate;
	}

	public void setMovieDate(String movieDate) {
		this.movieDate = movieDate;
	}

	public LocalDate getIssuingDate() {
		return issuingDate;
	}

	public void setIssuingDate(LocalDate issuingDate) {
		this.issuingDate = issuingDate;
	}

	public String getTime() {
		return time;
	}

	public void setTime(String time) {
		this.time = time;
	}

	public String getDateOfBirth() {
		return dateOfBirth;
	}

	public void setDateOfBirth(String dateOfBirth) {
		this.dateOfBirth = dateOfBirth;
	}

	public Movie getMovie() {
		return movie;
	}

	public void setMovie(Movie movie) {
		this.movie = movie;
	}

	@Override
	public String toString() {
		return "Ticket [id=" + id + ", firstName=" + firstName + ", lastName=" + lastName + ", movieDate=" + movieDate
				+ ", issuingDate=" + issuingDate + ", time=" + time + ", dateOfBirth=" + dateOfBirth + ", movie="
				+ movie + "]";
	}

}
