INSERT INTO Users (Name, Email, Password, PhoneNumber, Role, CreatedAt, UpdatedAt)
VALUES 
('Alice Silva', 'alice.silva@example.com', 'password123', '55119999999', 0, GETDATE(), GETDATE()),  -- Admin
('Carlos Souza', 'carlos.souza@example.com', 'password123', '55119888888', 1, GETDATE(), GETDATE()),  -- Customer
('Maria Santos', 'maria.santos@example.com', 'password123', NULL, 1, GETDATE(), GETDATE()),  -- Customer without PhoneNumber
('João Oliveira', 'joao.oliveira@example.com', 'password123', '55119777777', 1, GETDATE(), GETDATE()),  -- Customer
('Ana Paula', 'ana.paula@example.com', 'password123', NULL, 1, GETDATE(), GETDATE()),  -- Customer without PhoneNumber
('Lucas Almeida', 'lucas.almeida@example.com', 'password123', '55119666666', 0, GETDATE(), GETDATE());  -- Admin

INSERT INTO Tables (Capacity, IsAvailable)
VALUES 
(4, 1),  -- Mesa disponível com capacidade para 4 pessoas
(6, 0),  -- Mesa não disponível com capacidade para 6 pessoas
(2, 1),  -- Mesa disponível com capacidade para 2 pessoas
(8, 1),  -- Mesa disponível com capacidade para 8 pessoas
(10, 0),  -- Mesa não disponível com capacidade para 10 pessoas
(3, 1);  -- Mesa disponível com capacidade para 3 pessoas

INSERT INTO Reservations (UserId, TableId, ReservationDate, PartySize, Status, CreatedAt, UpdatedAt)
VALUES 
(2, 1, '2024-09-10 19:00:00', 4, 1, GETDATE(), GETDATE()),  -- Carlos reservando uma mesa para 4 pessoas
(3, 3, '2024-09-12 20:00:00', 2, 0, GETDATE(), GETDATE()),  -- Maria reservando uma mesa para 2 pessoas (Pendente)
(3, 2, '2024-09-15 18:00:00', 6, 2, GETDATE(), GETDATE()),  -- Maria reservando uma mesa para 6 pessoas (Cancelado)
(4, 4, '2024-09-20 21:00:00', 8, 1, GETDATE(), GETDATE()),  -- João reservando uma mesa para 8 pessoas
(5, 5, '2024-09-25 19:30:00', 10, 0, GETDATE(), GETDATE()),  -- Ana reservando uma mesa para 10 pessoas (Pendente)
(6, 6, '2024-09-30 17:00:00', 3, 2, GETDATE(), GETDATE());  -- Lucas reservando uma mesa para 3 pessoas (Cancelado)

INSERT INTO Notifications (UserId, Message, NotificationType, SentAt)
VALUES 
(2, 'Sua reserva foi confirmada.', 1, GETDATE()),  -- Notificação de confirmação de reserva para Carlos
(3, 'Lembrete: Você tem uma reserva para amanhã.', 0, DATEADD(day, -1, '2024-09-12 20:00:00')),  -- Lembrete para Maria
(3, 'Sua reserva foi cancelada.', 1, GETDATE()),  -- Notificação de cancelamento para Maria
(4, 'Sua reserva foi confirmada para 20 de setembro.', 1, GETDATE()),  -- Notificação de confirmação de reserva para João
(5, 'Lembrete: Sua reserva é amanhã às 19:30.', 0, DATEADD(day, -1, '2024-09-25 19:30:00')),  -- Lembrete para Ana
(6, 'Sua reserva foi cancelada.', 1, GETDATE());  -- Notificação de cancelamento para Lucas

INSERT INTO Waitlists (UserId, PartySize, RequestedTime, Status, CreatedAt)
VALUES 
(2, 4, '2024-09-10 18:00:00', 1, GETDATE()),  -- Carlos está na lista de espera e foi notificado
(3, 2, '2024-09-12 19:00:00', 0, GETDATE()),  -- Maria está na lista de espera (Aguardando)
(3, 6, '2024-09-15 17:00:00', 2, GETDATE()),  -- Maria foi cancelada na lista de espera
(4, 8, '2024-09-20 20:00:00', 0, GETDATE()),  -- João está na lista de espera (Aguardando)
(5, 10, '2024-09-25 18:00:00', 1, GETDATE()),  -- Ana foi notificada na lista de espera
(6, 3, '2024-09-30 16:00:00', 2, GETDATE());  -- Lucas foi cancelado na lista de espera
