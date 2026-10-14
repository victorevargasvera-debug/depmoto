using System;

namespace std
{
	// Token: 0x02000030 RID: 48
	internal enum errc
	{
		// Token: 0x0400024E RID: 590
		address_family_not_supported = 102,
		// Token: 0x0400024F RID: 591
		address_in_use = 100,
		// Token: 0x04000250 RID: 592
		address_not_available,
		// Token: 0x04000251 RID: 593
		already_connected = 113,
		// Token: 0x04000252 RID: 594
		argument_list_too_long = 7,
		// Token: 0x04000253 RID: 595
		argument_out_of_domain = 33,
		// Token: 0x04000254 RID: 596
		bad_address = 14,
		// Token: 0x04000255 RID: 597
		bad_file_descriptor = 9,
		// Token: 0x04000256 RID: 598
		bad_message = 104,
		// Token: 0x04000257 RID: 599
		broken_pipe = 32,
		// Token: 0x04000258 RID: 600
		connection_aborted = 106,
		// Token: 0x04000259 RID: 601
		connection_already_in_progress = 103,
		// Token: 0x0400025A RID: 602
		connection_refused = 107,
		// Token: 0x0400025B RID: 603
		connection_reset,
		// Token: 0x0400025C RID: 604
		cross_device_link = 18,
		// Token: 0x0400025D RID: 605
		destination_address_required = 109,
		// Token: 0x0400025E RID: 606
		device_or_resource_busy = 16,
		// Token: 0x0400025F RID: 607
		directory_not_empty = 41,
		// Token: 0x04000260 RID: 608
		executable_format_error = 8,
		// Token: 0x04000261 RID: 609
		file_exists = 17,
		// Token: 0x04000262 RID: 610
		file_too_large = 27,
		// Token: 0x04000263 RID: 611
		filename_too_long = 38,
		// Token: 0x04000264 RID: 612
		function_not_supported = 40,
		// Token: 0x04000265 RID: 613
		host_unreachable = 110,
		// Token: 0x04000266 RID: 614
		identifier_removed,
		// Token: 0x04000267 RID: 615
		illegal_byte_sequence = 42,
		// Token: 0x04000268 RID: 616
		inappropriate_io_control_operation = 25,
		// Token: 0x04000269 RID: 617
		interrupted = 4,
		// Token: 0x0400026A RID: 618
		invalid_argument = 22,
		// Token: 0x0400026B RID: 619
		invalid_seek = 29,
		// Token: 0x0400026C RID: 620
		io_error = 5,
		// Token: 0x0400026D RID: 621
		is_a_directory = 21,
		// Token: 0x0400026E RID: 622
		message_size = 115,
		// Token: 0x0400026F RID: 623
		network_down,
		// Token: 0x04000270 RID: 624
		network_reset,
		// Token: 0x04000271 RID: 625
		network_unreachable,
		// Token: 0x04000272 RID: 626
		no_buffer_space,
		// Token: 0x04000273 RID: 627
		no_child_process = 10,
		// Token: 0x04000274 RID: 628
		no_link = 121,
		// Token: 0x04000275 RID: 629
		no_lock_available = 39,
		// Token: 0x04000276 RID: 630
		no_message_available = 120,
		// Token: 0x04000277 RID: 631
		no_message = 122,
		// Token: 0x04000278 RID: 632
		no_protocol_option,
		// Token: 0x04000279 RID: 633
		no_space_on_device = 28,
		// Token: 0x0400027A RID: 634
		no_stream_resources = 124,
		// Token: 0x0400027B RID: 635
		no_such_device_or_address = 6,
		// Token: 0x0400027C RID: 636
		no_such_device = 19,
		// Token: 0x0400027D RID: 637
		no_such_file_or_directory = 2,
		// Token: 0x0400027E RID: 638
		no_such_process,
		// Token: 0x0400027F RID: 639
		not_a_directory = 20,
		// Token: 0x04000280 RID: 640
		not_a_socket = 128,
		// Token: 0x04000281 RID: 641
		not_a_stream = 125,
		// Token: 0x04000282 RID: 642
		not_connected,
		// Token: 0x04000283 RID: 643
		not_enough_memory = 12,
		// Token: 0x04000284 RID: 644
		not_supported = 129,
		// Token: 0x04000285 RID: 645
		operation_canceled = 105,
		// Token: 0x04000286 RID: 646
		operation_in_progress = 112,
		// Token: 0x04000287 RID: 647
		operation_not_permitted = 1,
		// Token: 0x04000288 RID: 648
		operation_not_supported = 130,
		// Token: 0x04000289 RID: 649
		operation_would_block = 140,
		// Token: 0x0400028A RID: 650
		owner_dead = 133,
		// Token: 0x0400028B RID: 651
		permission_denied = 13,
		// Token: 0x0400028C RID: 652
		protocol_error = 134,
		// Token: 0x0400028D RID: 653
		protocol_not_supported,
		// Token: 0x0400028E RID: 654
		read_only_file_system = 30,
		// Token: 0x0400028F RID: 655
		resource_deadlock_would_occur = 36,
		// Token: 0x04000290 RID: 656
		resource_unavailable_try_again = 11,
		// Token: 0x04000291 RID: 657
		result_out_of_range = 34,
		// Token: 0x04000292 RID: 658
		state_not_recoverable = 127,
		// Token: 0x04000293 RID: 659
		stream_timeout = 137,
		// Token: 0x04000294 RID: 660
		text_file_busy = 139,
		// Token: 0x04000295 RID: 661
		timed_out = 138,
		// Token: 0x04000296 RID: 662
		too_many_files_open_in_system = 23,
		// Token: 0x04000297 RID: 663
		too_many_files_open,
		// Token: 0x04000298 RID: 664
		too_many_links = 31,
		// Token: 0x04000299 RID: 665
		too_many_symbolic_link_levels = 114,
		// Token: 0x0400029A RID: 666
		value_too_large = 132,
		// Token: 0x0400029B RID: 667
		wrong_protocol_type = 136
	}
}
