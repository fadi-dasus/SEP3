package sep.via.dk.sep3JPA.controller;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpHeaders;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import sep.via.dk.sep3JPA.domain.Owner;
import sep.via.dk.sep3JPA.service.ownerService.OwnerService;

@RestController
@RequestMapping("/sep3")
public class OwnerController {

	@Autowired
	private OwnerService ownerService;

	@GetMapping("/owner/{id}")
	public ResponseEntity<Owner> getOwnerById(@PathVariable("id") Integer id) {
		Owner owner = ownerService.getOwnerById(id);
		return new ResponseEntity<Owner>(owner, HttpStatus.OK);

	}

	@PostMapping("/owner")
	public ResponseEntity<Void> addOwner(@RequestBody Owner owner) {
		boolean exist = ownerService.addOwner(owner);
		if (!exist)
			return new ResponseEntity<Void>(HttpStatus.CONFLICT);
		HttpHeaders headers = new HttpHeaders();

		return new ResponseEntity<Void>(headers, HttpStatus.CREATED);

	}

}