if not exists (select * from Employees where FirstName in ('Jack'))
begin 
insert into Employees (FirstName, Lastname, City, State) values 
('Jack','Forst','Denver','Co'),
('Rogger','Rabbit','Seattle','Washington')
end

