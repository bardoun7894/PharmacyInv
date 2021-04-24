-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 24, 2021 at 06:43 AM
-- Server version: 10.4.11-MariaDB
-- PHP Version: 7.4.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `pharma`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbladjustment`
--

CREATE TABLE `tbladjustment` (
  `id` int(11) NOT NULL,
  `pid` int(11) NOT NULL,
  `qty` int(11) NOT NULL,
  `stype` varchar(50) NOT NULL,
  `reason` text NOT NULL,
  `adjustedby` varchar(50) NOT NULL,
  `sdate` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbladjustment`
--

INSERT INTO `tbladjustment` (`id`, `pid`, `qty`, `stype`, `reason`, `adjustedby`, `sdate`) VALUES
(2, 9, 5, 'اضافة للمخزن', 'plus', 'admin', '2021-04-23'),
(3, 9, 2, 'اضافة للمخزن', 'add', 'admin', '2021-04-23'),
(4, 9, 2, 'الحذف من المخزن', 'add', 'admin', '2021-04-23');

-- --------------------------------------------------------

--
-- Table structure for table `tblbrand`
--

CREATE TABLE `tblbrand` (
  `id` int(11) NOT NULL,
  `brand` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tblbrand`
--

INSERT INTO `tblbrand` (`id`, `brand`) VALUES
(6, 'leopic'),
(7, 'kathrex'),
(8, 'Pritor'),
(9, 'Dizitab'),
(10, 'Qasar'),
(11, 'nodo');

-- --------------------------------------------------------

--
-- Table structure for table `tblcart`
--

CREATE TABLE `tblcart` (
  `id` int(11) NOT NULL,
  `invoice` varchar(50) NOT NULL,
  `pid` int(11) NOT NULL,
  `price` decimal(10,2) NOT NULL,
  `qty` int(11) NOT NULL,
  `total` decimal(10,2) NOT NULL,
  `sdate` date NOT NULL,
  `user` varchar(50) NOT NULL,
  `status` varchar(50) NOT NULL DEFAULT 'Pending'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tblcart`
--

INSERT INTO `tblcart` (`id`, `invoice`, `pid`, `price`, `qty`, `total`, `sdate`, `user`, `status`) VALUES
(65, '201912250001', 9, '49.00', 1, '49.00', '2019-12-25', 'mohamed bardouni ', 'Pending'),
(66, '201912250001', 9, '49.00', 1, '49.00', '2019-12-25', 'mohamed bardouni ', 'Pending'),
(67, '201912250001', 9, '49.00', 1, '49.00', '2019-12-25', 'mohamed bardouni ', 'Pending'),
(68, '201912250001', 9, '49.00', 1, '49.00', '2019-12-25', 'mohamed bardouni ', 'Pending'),
(69, '201912250001', 9, '49.00', 1, '49.00', '2019-12-25', 'mohamed bardouni ', 'Pending'),
(70, '201912250001', 9, '49.00', 1, '49.00', '2019-12-25', 'mohamed bardouni ', 'Pending'),
(71, '201912250002', 9, '49.00', 1, '49.00', '2019-12-25', 'mohamed bardouni ', 'Pending'),
(72, '201912250002', 9, '49.00', 1, '49.00', '2019-12-25', 'mohamed bardouni ', 'Pending'),
(73, '201912250002', 9, '49.00', 1, '49.00', '2019-12-25', 'mohamed bardouni ', 'Pending'),
(74, '201912250002', 9, '49.00', 1, '49.00', '2019-12-25', 'mohamed bardouni ', 'Pending'),
(75, '201912250003', 9, '49.00', 1, '49.00', '2019-12-25', 'mohamed bardouni ', 'Sold'),
(76, '201912250003', 9, '49.00', 1, '49.00', '2019-12-25', 'mohamed bardouni ', 'Sold'),
(77, '201912250003', 9, '49.00', 1, '49.00', '2019-12-25', 'mohamed bardouni ', 'Sold'),
(78, '201912250004', 9, '49.00', 1, '49.00', '2019-12-25', 'mohamed bardouni ', 'Sold'),
(79, '201912250004', 9, '49.00', 1, '49.00', '2019-12-25', 'mohamed bardouni ', 'Sold'),
(81, '201912250005', 9, '49.00', 1, '49.00', '2019-12-25', 'mohamed bardouni ', 'Pending'),
(82, '201912250006', 9, '49.00', 1, '49.00', '2019-12-25', 'mohamed bardouni ', 'Sold'),
(83, '201912260001', 9, '49.00', 1, '49.00', '2019-12-26', 'mohamed bardouni ', 'Sold'),
(84, '201912260002', 9, '49.00', 1, '49.00', '2019-12-26', 'mohamed bardouni ', 'Sold'),
(85, '201912260003', 9, '49.00', 1, '49.00', '2019-12-26', 'mohamed bardouni ', 'Sold'),
(86, '201912260004', 9, '49.00', 1, '49.00', '2019-12-26', 'mohamed bardouni ', 'Sold'),
(87, '201912260005', 9, '49.00', 1, '49.00', '2019-12-26', 'mohamed bardouni ', 'Sold'),
(88, '201912260006', 9, '49.00', 1, '49.00', '2019-12-26', 'mohamed bardouni ', 'Sold'),
(89, '201912260007', 9, '49.00', 1, '49.00', '2019-12-26', 'mohamed bardouni ', 'Sold'),
(90, '201912260008', 9, '49.00', 1, '49.00', '2019-12-26', 'mohamed bardouni ', 'Sold'),
(91, '201912260009', 9, '49.00', 1, '49.00', '2019-12-26', 'mohamed bardouni ', 'Sold'),
(92, '201912260010', 9, '49.00', 1, '49.00', '2019-12-26', 'mohamed bardouni ', 'Sold'),
(93, '201912260011', 9, '49.00', 1, '49.00', '2019-12-26', 'mohamed bardouni ', 'Sold'),
(94, '201912260011', 9, '49.00', 2, '98.00', '2019-12-26', 'mohamed bardouni ', 'Sold'),
(95, '201912260011', 9, '49.00', 33, '1617.00', '2019-12-26', 'mohamed bardouni ', 'Sold'),
(96, '201912260012', 9, '49.00', 1, '49.00', '2019-12-26', 'mohamed bardouni ', 'Sold'),
(97, '201912260012', 9, '49.00', 1, '49.00', '2019-12-26', 'mohamed bardouni ', 'Sold'),
(98, '201912260013', 9, '49.00', 1, '49.00', '2019-12-26', 'mohamed bardouni ', 'Sold'),
(99, '201912260013', 9, '49.00', 1, '49.00', '2019-12-26', 'mohamed bardouni ', 'Sold'),
(100, '201912260014', 9, '49.00', 10, '490.00', '2019-12-26', 'mohamed bardouni ', 'Sold'),
(101, '201912260015', 10, '19.00', 11, '209.00', '2019-12-26', 'mohamed bardouni ', 'Sold'),
(102, '201912260016', 11, '19.00', 2, '38.00', '2019-12-26', 'mohamed bardouni ', 'Sold'),
(103, '201912260017', 11, '19.00', 108, '2052.00', '2019-12-26', 'mohamed bardouni ', 'Sold'),
(104, '201912280001', 9, '49.00', 1, '49.00', '2019-12-28', 'mohannad', 'Sold'),
(105, '201912280002', 9, '49.00', 20, '980.00', '2019-12-28', 'mohannad', 'Sold'),
(106, '201912280003', 9, '49.00', 79, '3871.00', '2019-12-28', 'mohannad', 'Sold'),
(107, '201912280003', 10, '19.00', 111, '2109.00', '2019-12-28', 'mohannad', 'Sold'),
(108, '201912300001', 9, '49.00', 5, '245.00', '2019-12-30', 'mohannad', 'Sold'),
(109, '201912300002', 9, '49.00', 9, '441.00', '2019-12-30', 'mohannad', 'Sold'),
(110, '202011250001', 10, '19.00', 1, '19.00', '2020-11-25', 'admin', 'Pending'),
(112, '202011250002', 10, '19.00', 3, '57.00', '2020-11-25', 'admin', 'Sold'),
(113, '202011250002', 10, '19.00', 1, '19.00', '2020-11-25', 'admin', 'Sold'),
(114, '202011250002', 10, '19.00', 2, '38.00', '2020-11-25', 'admin', 'Sold'),
(115, '202011250002', 10, '19.00', 1, '19.00', '2020-11-25', 'admin', 'Sold'),
(116, '202011250003', 9, '49.00', 1, '49.00', '2020-11-25', 'admin', 'Sold');

-- --------------------------------------------------------

--
-- Table structure for table `tblclassification`
--

CREATE TABLE `tblclassification` (
  `id` int(5) NOT NULL,
  `classification` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tblclassification`
--

INSERT INTO `tblclassification` (`id`, `classification`) VALUES
(3, 'Stimulant laxative'),
(4, 'Mouth Wash'),
(5, 'Diabetes'),
(6, 'sentetic hormone'),
(7, 'beta-Blockers');

-- --------------------------------------------------------

--
-- Table structure for table `tbldiscount`
--

CREATE TABLE `tbldiscount` (
  `id` int(11) NOT NULL,
  `description` varchar(50) NOT NULL,
  `discount` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbldiscount`
--

INSERT INTO `tbldiscount` (`id`, `description`, `discount`) VALUES
(6, 'تخفيض ال 20 في المئة', '0.20'),
(7, 'تخفيض ال 30 في المئة', '0.30'),
(9, 'تخفيض ال 50 في المئة ', '0.50');

-- --------------------------------------------------------

--
-- Table structure for table `tblformulation`
--

CREATE TABLE `tblformulation` (
  `id` int(11) NOT NULL,
  `formulation` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tblformulation`
--

INSERT INTO `tblformulation` (`id`, `formulation`) VALUES
(5, '20mg'),
(6, '15mg');

-- --------------------------------------------------------

--
-- Table structure for table `tblgeneric`
--

CREATE TABLE `tblgeneric` (
  `id` int(11) NOT NULL,
  `generic` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tblgeneric`
--

INSERT INTO `tblgeneric` (`id`, `generic`) VALUES
(9, 'salbu-Guaphinisin'),
(10, 'norfloxacin'),
(11, 'Bacampphilin'),
(12, 'Doxyciline'),
(13, 'Tetracyclin');

-- --------------------------------------------------------

--
-- Table structure for table `tblpayment`
--

CREATE TABLE `tblpayment` (
  `id` int(11) NOT NULL,
  `invoice` varchar(50) NOT NULL,
  `amountdue` decimal(10,2) NOT NULL,
  `sdate` datetime NOT NULL,
  `user` varchar(50) NOT NULL,
  `subtotal` decimal(10,2) NOT NULL,
  `vat` decimal(10,2) NOT NULL,
  `discount` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tblpayment`
--

INSERT INTO `tblpayment` (`id`, `invoice`, `amountdue`, `sdate`, `user`, `subtotal`, `vat`, `discount`) VALUES
(90, '201912260011', '1587.60', '2019-12-26 00:00:00', 'mohamed bardouni ', '1764.00', '176.40', '0.00'),
(91, '201912260012', '79.38', '2019-12-26 00:00:00', 'mohamed bardouni ', '88.20', '8.82', '9.80'),
(92, '201912260013', '62.72', '2019-12-26 00:00:00', 'mohamed bardouni ', '78.40', '15.68', '19.60'),
(93, '201912260014', '313.60', '2019-12-26 00:00:00', 'mohamed bardouni ', '392.00', '78.40', '98.00'),
(94, '201912260015', '167.20', '2019-12-26 00:00:00', 'mohamed bardouni ', '209.00', '41.80', '0.00'),
(95, '201912260016', '30.40', '2019-12-26 00:00:00', 'mohamed bardouni ', '38.00', '7.60', '0.00'),
(96, '201912260017', '1641.60', '2019-12-26 00:00:00', 'mohamed bardouni ', '2052.00', '410.40', '0.00'),
(97, '201912280001', '39.20', '2019-12-28 00:00:00', 'mohannad', '49.00', '9.80', '0.00'),
(98, '201912280002', '392.00', '2019-12-28 00:00:00', 'mohannad', '490.00', '98.00', '490.00'),
(99, '201912280003', '4392.00', '2019-12-28 00:00:00', 'mohannad', '5490.00', '1098.00', '490.00'),
(100, '201912300001', '137.20', '2019-12-30 00:00:00', 'mohannad', '171.50', '34.30', '73.50'),
(101, '201912300002', '352.80', '2019-12-30 00:00:00', 'mohannad', '441.00', '88.20', '0.00'),
(102, '202011250002', '85.12', '2020-11-25 00:00:00', 'admin', '106.40', '21.28', '26.60'),
(103, '202011250003', '39.20', '2020-11-25 00:00:00', 'admin', '49.00', '9.80', '0.00');

-- --------------------------------------------------------

--
-- Table structure for table `tblproduct`
--

CREATE TABLE `tblproduct` (
  `id` int(11) NOT NULL,
  `barcode` varchar(50) NOT NULL,
  `bid` int(11) NOT NULL,
  `gid` int(11) NOT NULL,
  `cid` int(11) NOT NULL,
  `tid` int(11) NOT NULL,
  `fid` int(11) NOT NULL,
  `reorder` int(11) NOT NULL,
  `qty` int(11) NOT NULL,
  `price` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tblproduct`
--

INSERT INTO `tblproduct` (`id`, `barcode`, `bid`, `gid`, `cid`, `tid`, `fid`, `reorder`, `qty`, `price`) VALUES
(9, '199999', 9, 9, 7, 7, 6, 5, 53, '49.00'),
(10, '111111', 10, 11, 7, 7, 6, 5, 1, '19.00'),
(11, '22222222', 10, 11, 7, 7, 6, 5, 4, '19.00'),
(12, '398989849934934', 9, 12, 5, 7, 6, 10, 100, '100.00');

-- --------------------------------------------------------

--
-- Table structure for table `tblstockin`
--

CREATE TABLE `tblstockin` (
  `id` int(11) NOT NULL,
  `refno` varchar(50) DEFAULT NULL,
  `recievedBy` varchar(50) NOT NULL,
  `pid` int(11) NOT NULL,
  `qty` int(11) NOT NULL,
  `sdate` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tblstockin`
--

INSERT INTO `tblstockin` (`id`, `refno`, `recievedBy`, `pid`, `qty`, `sdate`) VALUES
(44, 'mo', '3333', 9, 20, '2019-12-24'),
(45, '1999999', 'hocain', 9, 60, '2019-12-26'),
(46, '1999828272', 'mohamed', 10, 30, '2019-12-26'),
(47, 'bo', 'momo', 11, 80, '2019-12-26'),
(48, '189171987', 'mohamed', 9, 40, '2019-12-28'),
(49, '43-0582-030', 'mohamed', 9, 10, '2021-04-15');

-- --------------------------------------------------------

--
-- Table structure for table `tbltype`
--

CREATE TABLE `tbltype` (
  `id` int(11) NOT NULL,
  `type` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbltype`
--

INSERT INTO `tbltype` (`id`, `type`) VALUES
(5, 'Syrup adult'),
(6, 'Meter dose enhaler'),
(7, 'Ampule'),
(8, 'Syrep'),
(9, 'N/A');

-- --------------------------------------------------------

--
-- Table structure for table `tbluser`
--

CREATE TABLE `tbluser` (
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `name` varchar(50) NOT NULL,
  `user_type` varchar(50) NOT NULL,
  `status` varchar(50) NOT NULL DEFAULT 'متاح'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbluser`
--

INSERT INTO `tbluser` (`username`, `password`, `name`, `user_type`, `status`) VALUES
('admin', 'admin', 'moha', 'الادمين', 'متاح'),
('moha', 'moha', 'moha', 'امين الصندوق', 'متاح');

-- --------------------------------------------------------

--
-- Table structure for table `tblvat`
--

CREATE TABLE `tblvat` (
  `vat` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tblvat`
--

INSERT INTO `tblvat` (`vat`) VALUES
('0.20');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbladjustment`
--
ALTER TABLE `tbladjustment`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tblbrand`
--
ALTER TABLE `tblbrand`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tblcart`
--
ALTER TABLE `tblcart`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tblclassification`
--
ALTER TABLE `tblclassification`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tbldiscount`
--
ALTER TABLE `tbldiscount`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tblformulation`
--
ALTER TABLE `tblformulation`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tblgeneric`
--
ALTER TABLE `tblgeneric`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tblpayment`
--
ALTER TABLE `tblpayment`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tblproduct`
--
ALTER TABLE `tblproduct`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tblstockin`
--
ALTER TABLE `tblstockin`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tbltype`
--
ALTER TABLE `tbltype`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tbluser`
--
ALTER TABLE `tbluser`
  ADD PRIMARY KEY (`username`);

--
-- Indexes for table `tblvat`
--
ALTER TABLE `tblvat`
  ADD PRIMARY KEY (`vat`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbladjustment`
--
ALTER TABLE `tbladjustment`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `tblbrand`
--
ALTER TABLE `tblbrand`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `tblcart`
--
ALTER TABLE `tblcart`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=117;

--
-- AUTO_INCREMENT for table `tblclassification`
--
ALTER TABLE `tblclassification`
  MODIFY `id` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `tbldiscount`
--
ALTER TABLE `tbldiscount`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `tblformulation`
--
ALTER TABLE `tblformulation`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `tblgeneric`
--
ALTER TABLE `tblgeneric`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `tblpayment`
--
ALTER TABLE `tblpayment`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=104;

--
-- AUTO_INCREMENT for table `tblproduct`
--
ALTER TABLE `tblproduct`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `tblstockin`
--
ALTER TABLE `tblstockin`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=50;

--
-- AUTO_INCREMENT for table `tbltype`
--
ALTER TABLE `tbltype`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
