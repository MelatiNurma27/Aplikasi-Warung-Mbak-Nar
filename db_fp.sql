-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 26, 2024 at 10:13 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_fp`
--

-- --------------------------------------------------------

--
-- Table structure for table `jenis_pembayaran`
--

CREATE TABLE `jenis_pembayaran` (
  `ID_JenisPembayaran` int(11) NOT NULL,
  `jenis_pembayaran` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `jenis_pembayaran`
--

INSERT INTO `jenis_pembayaran` (`ID_JenisPembayaran`, `jenis_pembayaran`) VALUES
(1, 'Tunai'),
(2, 'Non Tunai');

-- --------------------------------------------------------

--
-- Table structure for table `table_detailtransaksi`
--

CREATE TABLE `table_detailtransaksi` (
  `ID_Detail` int(11) NOT NULL,
  `ID_Transaksi` int(11) NOT NULL,
  `ID_Menu` int(11) NOT NULL,
  `jumlah` int(11) NOT NULL,
  `total` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `table_detailtransaksi`
--

INSERT INTO `table_detailtransaksi` (`ID_Detail`, `ID_Transaksi`, `ID_Menu`, `jumlah`, `total`) VALUES
(13, 241226001, 2, 2, 10000.00),
(14, 241226002, 1, 3, 15000.00),
(15, 241226003, 1, 1, 5000.00),
(16, 241226004, 1, 2, 10000.00),
(17, 241226005, 2, 2, 10000.00),
(18, 241226006, 1, 2, 10000.00),
(19, 241226007, 1, 5, 25000.00),
(20, 241226008, 1, 4, 20000.00),
(21, 241226009, 2, 3, 15000.00),
(22, 241226010, 2, 3, 15000.00),
(23, 241226011, 2, 5, 25000.00),
(24, 241226012, 1, 1, 5000.00),
(25, 241226013, 1, 5, 25000.00),
(26, 241226014, 1, 4, 20000.00),
(27, 241226015, 1, 2, 10000.00),
(28, 241226016, 2, 3, 15000.00),
(29, 241226017, 1, 1, 5000.00),
(30, 241226018, 1, 3, 15000.00),
(31, 241226019, 1, 3, 15000.00),
(32, 241226020, 1, 3, 15000.00),
(33, 241226021, 1, 4, 20000.00),
(34, 241226022, 1, 4, 20000.00),
(35, 241226023, 1, 1, 5000.00),
(36, 241226024, 1, 1, 5000.00),
(37, 241226025, 10, 1, 9000.00);

-- --------------------------------------------------------

--
-- Table structure for table `table_kategori`
--

CREATE TABLE `table_kategori` (
  `ID_Kategori` int(11) NOT NULL,
  `Kategori` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `table_kategori`
--

INSERT INTO `table_kategori` (`ID_Kategori`, `Kategori`) VALUES
(1, 'Makanan'),
(2, 'Minuman');

-- --------------------------------------------------------

--
-- Table structure for table `table_laporan`
--

CREATE TABLE `table_laporan` (
  `ID_Laporan` int(11) NOT NULL,
  `ID_Transaksi` int(11) DEFAULT NULL,
  `ID_JenisPembayaran` int(11) NOT NULL,
  `tanggal` datetime DEFAULT NULL,
  `total_pembayaran` decimal(10,3) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `table_laporan`
--

INSERT INTO `table_laporan` (`ID_Laporan`, `ID_Transaksi`, `ID_JenisPembayaran`, `tanggal`, `total_pembayaran`) VALUES
(3, 241226014, 2, '2024-12-26 02:12:27', 20.000),
(4, 241226017, 1, '2024-12-26 02:18:51', 5.000),
(5, 241226018, 1, '2024-12-26 02:21:10', 15.000),
(6, 241226019, 2, '2024-12-26 02:21:45', 15.000),
(7, 241226022, 2, '2024-12-26 02:28:58', 20.000),
(8, 241226023, 1, '2024-12-26 03:20:42', 5.000),
(9, 241226024, 1, '2024-12-26 13:24:11', 5.000),
(10, 241226025, 1, '2024-12-26 15:53:40', 9.000);

-- --------------------------------------------------------

--
-- Table structure for table `table_menu`
--

CREATE TABLE `table_menu` (
  `ID_Menu` int(11) NOT NULL,
  `ID_Kategori` int(11) DEFAULT NULL,
  `menu` varchar(50) DEFAULT NULL,
  `harga` decimal(10,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `table_menu`
--

INSERT INTO `table_menu` (`ID_Menu`, `ID_Kategori`, `menu`, `harga`) VALUES
(1, 1, 'Nasi Putih', 5000),
(2, 2, 'Air Mineral', 5000),
(3, 1, 'Es Teh Kecill', 4000),
(4, 1, 'Telur Dadar', 5000),
(5, 2, 'Es Teh Jumbo', 6000),
(6, 1, 'Atii', 5000),
(7, 1, 'Sate per Tusuk', 2500),
(8, 1, 'Ampela', 5000),
(9, 1, 'Paru', 10000),
(10, 1, 'Ayam Sayap', 9000),
(11, 1, 'Ayam Paha Atas/Dada', 10000),
(12, 1, 'Ayam Paha Bawah', 9000),
(13, 2, 'Es Cao', 6000),
(14, 2, 'Es Coklat', 6000),
(15, 2, 'Cappucino', 6000),
(16, 2, 'Kopi Sachet', 4000),
(17, 2, 'Es Jeruk Kecil', 6000),
(18, 2, 'Es Jeruk Jumbo', 9000),
(19, 2, 'Teh Hangat', 3000);

-- --------------------------------------------------------

--
-- Table structure for table `table_pembayaran`
--

CREATE TABLE `table_pembayaran` (
  `ID_Bayar` int(11) NOT NULL,
  `ID_Transaksi` int(50) DEFAULT NULL,
  `ID_JenisPembayaran` int(11) NOT NULL,
  `uang_bayar` decimal(10,2) NOT NULL,
  `uang_kembali` decimal(10,3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `table_pembayaran`
--

INSERT INTO `table_pembayaran` (`ID_Bayar`, `ID_Transaksi`, `ID_JenisPembayaran`, `uang_bayar`, `uang_kembali`) VALUES
(3, 241226018, 1, 20000.00, 5.000),
(4, 241226019, 2, 15.00, 0.000),
(6, 241226023, 1, 12222.00, 7.222),
(7, 241226024, 1, 7000.00, 2.000),
(8, 241226025, 1, 10000.00, 1.000);

-- --------------------------------------------------------

--
-- Table structure for table `table_transaksi`
--

CREATE TABLE `table_transaksi` (
  `ID_Transaksi` int(11) NOT NULL,
  `Tanggal_Transaksi` datetime NOT NULL,
  `Nama_Pelanggan` varchar(50) NOT NULL,
  `Total` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `table_transaksi`
--

INSERT INTO `table_transaksi` (`ID_Transaksi`, `Tanggal_Transaksi`, `Nama_Pelanggan`, `Total`) VALUES
(241226001, '2024-12-26 01:35:55', 'fatma', 10000.00),
(241226002, '2024-12-26 01:37:02', 'gagag', 15000.00),
(241226003, '2024-12-26 01:42:00', 'fat', 5000.00),
(241226004, '2024-12-26 01:42:52', 'kaka', 10000.00),
(241226005, '2024-12-26 01:44:36', 'aka', 10000.00),
(241226006, '2024-12-26 01:46:42', 'jj', 10000.00),
(241226007, '2024-12-26 01:49:12', 'gggg', 25000.00),
(241226008, '2024-12-26 01:52:53', 'gg', 20000.00),
(241226009, '2024-12-26 01:55:02', 'gasg', 15000.00),
(241226010, '2024-12-26 01:56:27', 'gag', 15000.00),
(241226011, '2024-12-26 02:00:25', 'gg', 25000.00),
(241226012, '2024-12-26 02:06:00', 'gag', 5000.00),
(241226013, '2024-12-26 02:09:02', 'faf', 25000.00),
(241226014, '2024-12-26 02:12:09', 'gghj', 20000.00),
(241226015, '2024-12-26 02:12:28', 'gg', 10000.00),
(241226016, '2024-12-26 02:17:30', 'gag', 15000.00),
(241226017, '2024-12-26 02:18:21', 'gaggs', 5000.00),
(241226018, '2024-12-26 02:18:53', 'hahh', 15000.00),
(241226019, '2024-12-26 02:21:11', 'gasdga', 15000.00),
(241226020, '2024-12-26 02:23:42', 'kajd', 15000.00),
(241226021, '2024-12-26 02:25:25', 'dghas', 20000.00),
(241226022, '2024-12-26 02:28:36', 'hdt', 20000.00),
(241226023, '2024-12-26 03:20:08', 'mel', 5000.00),
(241226024, '2024-12-26 13:23:27', 'orang', 5000.00),
(241226025, '2024-12-26 15:52:57', 'Melati', 9000.00);

-- --------------------------------------------------------

--
-- Table structure for table `table_user`
--

CREATE TABLE `table_user` (
  `ID_User` int(11) NOT NULL,
  `Username` varchar(50) NOT NULL,
  `Password` varchar(50) NOT NULL,
  `Role` enum('Owner','Kasir') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `table_user`
--

INSERT INTO `table_user` (`ID_User`, `Username`, `Password`, `Role`) VALUES
(1, 'owner', 'owner123', 'Owner'),
(2, 'kasir', 'kasir123', 'Kasir');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `jenis_pembayaran`
--
ALTER TABLE `jenis_pembayaran`
  ADD PRIMARY KEY (`ID_JenisPembayaran`);

--
-- Indexes for table `table_detailtransaksi`
--
ALTER TABLE `table_detailtransaksi`
  ADD PRIMARY KEY (`ID_Detail`),
  ADD KEY `table_detailtransaksi_ibfk_1` (`ID_Transaksi`),
  ADD KEY `table_detailtransaksi_ibfk_2` (`ID_Menu`);

--
-- Indexes for table `table_kategori`
--
ALTER TABLE `table_kategori`
  ADD PRIMARY KEY (`ID_Kategori`);

--
-- Indexes for table `table_laporan`
--
ALTER TABLE `table_laporan`
  ADD PRIMARY KEY (`ID_Laporan`),
  ADD KEY `ID_Transaksi` (`ID_Transaksi`),
  ADD KEY `table_laporan_ibfk_3` (`ID_JenisPembayaran`);

--
-- Indexes for table `table_menu`
--
ALTER TABLE `table_menu`
  ADD PRIMARY KEY (`ID_Menu`),
  ADD KEY `ID_Kategori` (`ID_Kategori`);

--
-- Indexes for table `table_pembayaran`
--
ALTER TABLE `table_pembayaran`
  ADD PRIMARY KEY (`ID_Bayar`),
  ADD KEY `table_bayar_ibfk_1` (`ID_Transaksi`),
  ADD KEY `table_bayar_ibfk_2` (`ID_JenisPembayaran`);

--
-- Indexes for table `table_transaksi`
--
ALTER TABLE `table_transaksi`
  ADD PRIMARY KEY (`ID_Transaksi`);

--
-- Indexes for table `table_user`
--
ALTER TABLE `table_user`
  ADD PRIMARY KEY (`ID_User`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `table_detailtransaksi`
--
ALTER TABLE `table_detailtransaksi`
  MODIFY `ID_Detail` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=38;

--
-- AUTO_INCREMENT for table `table_kategori`
--
ALTER TABLE `table_kategori`
  MODIFY `ID_Kategori` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `table_laporan`
--
ALTER TABLE `table_laporan`
  MODIFY `ID_Laporan` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `table_menu`
--
ALTER TABLE `table_menu`
  MODIFY `ID_Menu` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT for table `table_pembayaran`
--
ALTER TABLE `table_pembayaran`
  MODIFY `ID_Bayar` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `table_transaksi`
--
ALTER TABLE `table_transaksi`
  MODIFY `ID_Transaksi` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=241226026;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `table_detailtransaksi`
--
ALTER TABLE `table_detailtransaksi`
  ADD CONSTRAINT `table_detailtransaksi_ibfk_1` FOREIGN KEY (`ID_Transaksi`) REFERENCES `table_transaksi` (`ID_Transaksi`),
  ADD CONSTRAINT `table_detailtransaksi_ibfk_2` FOREIGN KEY (`ID_Menu`) REFERENCES `table_menu` (`ID_Menu`);

--
-- Constraints for table `table_laporan`
--
ALTER TABLE `table_laporan`
  ADD CONSTRAINT `table_laporan_ibfk_1` FOREIGN KEY (`ID_Transaksi`) REFERENCES `table_transaksi` (`ID_Transaksi`),
  ADD CONSTRAINT `table_laporan_ibfk_3` FOREIGN KEY (`ID_JenisPembayaran`) REFERENCES `jenis_pembayaran` (`ID_JenisPembayaran`);

--
-- Constraints for table `table_menu`
--
ALTER TABLE `table_menu`
  ADD CONSTRAINT `table_menu_ibfk_1` FOREIGN KEY (`ID_Kategori`) REFERENCES `table_kategori` (`ID_Kategori`);

--
-- Constraints for table `table_pembayaran`
--
ALTER TABLE `table_pembayaran`
  ADD CONSTRAINT `table_pembayaran_ibfk_1` FOREIGN KEY (`ID_Transaksi`) REFERENCES `table_transaksi` (`ID_Transaksi`),
  ADD CONSTRAINT `table_pembayaran_ibfk_2` FOREIGN KEY (`ID_JenisPembayaran`) REFERENCES `jenis_pembayaran` (`ID_JenisPembayaran`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
