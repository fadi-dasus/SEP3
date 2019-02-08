package sep.via.dk.sep3JPA.controller;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import sep.via.dk.sep3JPA.domain.Ticket;
import sep.via.dk.sep3JPA.service.ticket.TicketService;

@RestController
@RequestMapping("/sep3")
public class TicketController {

	@Autowired
	private TicketService ticketService;

	@PostMapping("/ticket")
	public ResponseEntity<Ticket> addTicket(@RequestBody Ticket ticket)  {
		
		
		boolean valid = ticketService.checkPayment();
		if (!valid)
			return new ResponseEntity<Ticket>(HttpStatus.NOT_ACCEPTABLE);
		ticketService.addTicket(ticket);
		return new ResponseEntity<Ticket>(ticket, HttpStatus.CREATED);

	}

	@GetMapping("/ticket/link")
	public ResponseEntity<String> getPaymentLink()  {

		String link = ticketService.getPaymentLink();

		return new ResponseEntity<String>(link, HttpStatus.OK);
	}
	
	
	@GetMapping("/ticket/link/thanks")
    public ResponseEntity<String> getPaymentThanks()  {

        String thankslink = "Thank you, you have paied";

        return new ResponseEntity<String>(thankslink, HttpStatus.OK);
    }

}
