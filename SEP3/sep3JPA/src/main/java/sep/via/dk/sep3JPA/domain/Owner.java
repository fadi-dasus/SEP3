package sep.via.dk.sep3JPA.domain;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.Table;

@Entity
@Table(name = "Owner")
public class Owner {


	@Id
	@GeneratedValue(strategy = GenerationType.AUTO)
	@Column(name = "user_id")
	private Integer id;

	@Column(name = "username", nullable = false)
	private String username;

	@Column(name = "password", length = 2000)
	private String password;

	@Column(name = "email", length = 2000)
	private String email;

	public Owner() {

	}

	public Owner(Integer id, String username, String password, String email) {

		this.id = id;
		this.username = username;
		this.password = password;
		this.email = email;
	}

	public String getEmail() {
		return email;
	}

	public void setEmail(String email) {
		this.email = email;
	}

	public Integer getId() {
		return id;
	}

	public void setId(Integer id) {
		this.id = id;
	}

	public String getUsername() {
		return username;
	}

	public void setUsername(String username) {
		this.username = username;
	}

	public String getPassword() {
		return password;
	}

	public void setPassword(String password) {
		this.password = password;
	}

	@Override
	public String toString() {
		return "Owner [id=" + id + ", username=" + username + ", password=" + password + ", email=" + email + "]";
	}

}
