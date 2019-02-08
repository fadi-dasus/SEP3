package sep.via.dk.sep3JPA.controller;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpHeaders;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import sep.via.dk.sep3JPA.domain.Message;
import sep.via.dk.sep3JPA.service.messageServic.MessageService;

@RestController
@RequestMapping("/sep3")
public class MessageController {

	@Autowired
	MessageService MessageService;

	@PostMapping("/message")
	public ResponseEntity<Void> addFeedBack(@RequestBody Message feedBack) {

		MessageService.addMessage(feedBack);

		HttpHeaders headers = new HttpHeaders();

		return new ResponseEntity<Void>(headers, HttpStatus.CREATED);
	}

	@GetMapping("/message")
	public ResponseEntity<List<Message>> getAllMovies() {

		List<Message> list = MessageService.getAllMessage();
		return new ResponseEntity<List<Message>>(list, HttpStatus.OK);

	}
}