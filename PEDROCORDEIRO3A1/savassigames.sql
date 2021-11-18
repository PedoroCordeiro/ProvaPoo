CREATE DATABASE IF NOT EXISTS `savassigames` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `savassigames`;

CREATE TABLE `game` (
  `codigo` int(11) NOT NULL,
  `nome` varchar(75) NOT NULL,
  `genero` varchar(75) NOT NULL,
  `valor` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

CREATE TABLE `login` (
  `codigo` int(11) NOT NULL,
  `email` varchar(75) NOT NULL,
  `senha` varchar(75) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

INSERT INTO `login` (`codigo`, `email`, `senha`) VALUES
(1, 'usuario@usuario', '123456');


ALTER TABLE `game`
  ADD PRIMARY KEY (`codigo`);

ALTER TABLE `login`
  ADD PRIMARY KEY (`codigo`);


ALTER TABLE `game`
  MODIFY `codigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

ALTER TABLE `login`
  MODIFY `codigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
