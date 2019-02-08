package sep.via.dk.sep3JPA.service.ownerService;

import sep.via.dk.sep3JPA.domain.Owner;

public interface OwnerService {

	boolean addOwner(Owner owner);

	Owner getOwnerById(int id) ;

}
