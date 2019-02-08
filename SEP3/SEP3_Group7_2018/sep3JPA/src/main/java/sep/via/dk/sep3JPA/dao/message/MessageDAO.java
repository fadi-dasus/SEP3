package sep.via.dk.sep3JPA.dao.message;

import java.util.List;

import sep.via.dk.sep3JPA.domain.Message;

public interface MessageDAO {
	public void addMessage(Message feedBack);

	public List<Message> getAllMessages();
}
