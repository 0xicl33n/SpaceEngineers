bool infector = true;
//payload is still being tested.
string payload ="IA0KYm9vbCBleHBsb2RlRXZlcnl0aGluZyA9IHRydWU7IC8vQ2hhbmdlIHRoaXMgaWYgeW91IGRvbid0IHdhbnQgdGhlIHdhcmhlYWRzIHRvIGV4cGxvZGUgYXV0b21hZ2ljYWxseQ0KaW50ICBkZXRhY2hEZWxheSA9IDE1OyAvL0RlbGF5IGJlZm9yZSB0aGUgcm90b3JzIGRldGFjaA0KYm9vbCBjYXJyaWVkQnlQYXlsb2FkID0gZmFsc2U7IC8vU2V0IGl0IHRydWUgaWYgeW91IGFyZSB1c2luZyBhIHBheWxvYWQsIHRoZW4gdGhlIHZpcnVzIHdvbid0IGF0dGFjayB1bnRpbCB5b3UgZGV0YWNoDQovLw0KYm9vbCBpbmZlY3RvciA9IHRydWU7IC8vUHJlcGFyaW5nIGZvciBpbmZlY3Rpb24gY2FwYWJpbGl0aWVzDQovLw0KDQovL0Jvb2xzIGFyZSBoZXJlDQpib29sIG1lc3NVcEFudGVubmFzID0gdHJ1ZTsNCmJvb2wgbWVzc1VwQmF0dGVyaWVzID0gdHJ1ZTsNCmJvb2wgbWVzc1VwQmVhY29ucyA9IHRydWU7DQpib29sIG1lc3NVcEJ1dHRvblBhbmVscyA9IHRydWU7DQpib29sIG1lc3NVcENhbWVyYXMgPSB0cnVlOw0KYm9vbCBtZXNzVXBDb2NrcGl0cyA9IHRydWU7DQpib29sIG1lc3NVcENvbGxlY3RvcnMgPSB0cnVlOw0KYm9vbCBtZXNzVXBDb25uZWN0b3JzID0gdHJ1ZTsNCmJvb2wgbWVzc1VwRG9vcnMgPSB0cnVlOw0KYm9vbCBtZXNzVXBEcmlsbHMgPSB0cnVlOw0KYm9vbCBtZXNzVXBUdXJyZXRzID0gdHJ1ZTsNCmJvb2wgbWVzc1VwR3Jhdml0eSA9IHRydWU7DQpib29sIG1lc3NVcEdyaW5kZXJzID0gdHJ1ZTsNCmJvb2wgbWVzc1VwR3lyb3MgPSB0cnVlOw0KYm9vbCBtZXNzVXBMaWdodHMgPSB0cnVlOw0KYm9vbCBtZXNzVXBMYW5kaW5nR2VhcnMgPSB0cnVlOw0KYm9vbCBtZXNzVXBSZWFjdG9ycyA9IHRydWU7DQpib29sIG1lc3NVcFRocnVzdGVycyA9IHRydWU7DQpib29sIG1lc3NVcE1lZGljYWxSb29tcyA9IHRydWU7DQpib29sIG1lc3NVcE1lcmdlQmxvY2tzID0gdHJ1ZTsNCmJvb2wgbWVzc1VwT3JlRGV0ZWN0b3JzID0gdHJ1ZTsNCmJvb2wgbWVzc1VwUGlzdG9ucyA9IHRydWU7DQpib29sIG1lc3NVcE1pc3NpbGVMYXVuY2hlcnMgPSB0cnVlOw0KYm9vbCBtZXNzVXBSb3RvcnMgPSB0cnVlOw0KYm9vbCBtZXNzVXBTZW5zb3JzID0gdHJ1ZTsNCmJvb2wgbWVzc1VwU291bmRCbG9ja3MgPSB0cnVlOw0KYm9vbCBtZXNzVXBXZWxkZXJzID0gdHJ1ZTsNCmJvb2wgbWVzc1VwV2hlZWxzID0gdHJ1ZTsNCg0KIA0KYm9vbCB0aHJvd091dEV2ZXJ5dGhpbmcgPSB0cnVlOw0KYm9vbCByZW5hbWVFdmVyeXRoaW5nID0gdHJ1ZTsNCiAgZm91cnR5dHdvLkNsZWFyKCk7DQogIEdyaWRUZXJtaW5hbFN5c3RlbS5HZXRCbG9ja3NPZlR5cGU8SU15VGVybWluYWxCbG9jaz4oZm91cnR5dHdvKTsNCiANCiAgYm9vbCByb2xsRGV0YWNoVGltZXIgPSB0cnVlOw0KIA0KICBpZihjYXJyaWVkQnlQYXlsb2FkKQ0KICB7DQogICAgY29ja3BpdHMuQ2xlYXIoKTsNCiAgICBHcmlkVGVybWluYWxTeXN0ZW0uR2V0QmxvY2tzT2ZUeXBlPElNeVNoaXBDb250cm9sbGVyPihjb2NrcGl0cyk7IC8vUmVtb3RlIGNvbnRyb2wgaW5jbHVkZWQsIHdvcmtzIHdpdGggcGF5bG9hZCBkcm9uZXMNCiAgICBpZihjb2NrcGl0Q291bnQgPT0gLTEpDQogICAgew0KICAgICAgY29ja3BpdENvdW50ID0gY29ja3BpdHMuQ291bnQ7DQogICAgfQ0KICAgIGlmKGNvY2twaXRzLkNvdW50ID09IGNvY2twaXRDb3VudCkNCiAgICB7DQogICAgICByZXR1cm47DQogICAgfQ0KICB9DQogDQogIGZvcihpbnQgaT0wOyBpIDwgZm91cnR5dHdvLkNvdW50OyBpKyspIC8vSXRlcmF0ZSBvdmVyIGV2ZXJ5dGhpbmcNCiAgew0KICAgIHZhciBibG9jayA9IGZvdXJ0eXR3b1tpXTsgLy9NYWtlIG91ciBsaWZlIGEgbGl0dGxlIGJpdCBlYXNpZXINCiAgIA0KICAgIGlmKGJsb2NrIGlzIElNeVJhZGlvQW50ZW5uYSAmJiBtZXNzVXBBbnRlbm5hcykNCiAgICB7DQogICAgICBibG9jay5HZXRBY3Rpb25XaXRoTmFtZSgiT25PZmZfT2ZmIikuQXBwbHkoYmxvY2spOyAvL1R1cm4gYW50ZW5uYXMgb2ZmLCB0aGF0J3MgdGhlIGJlc3Qgd2UgY2FuIGRvIHJpZ2h0IG5vdw0KICAgIH0NCiAgIA0KICAgIC8vQXJjIGZ1cm5hY2VzIGhhbmRsZWQgYXMgcHJvZHVjdGlvbiBibG9ja3MNCiAgIA0KICAgIC8vQXJ0aWZpY2FsIG1hc3NlcyBkb2Vzbid0IG5lZWQgYW55IGhhbmRsaW5nDQogICANCiAgICAvL0Fzc2VtYmxlcnMgaGFuZGxlZCBhcyBwcm9kdWN0aW9uIGJsb2Nrcw0KICAgDQogICAgaWYoYmxvY2sgaXMgSU15QmF0dGVyeUJsb2NrICYmIG1lc3NVcEJhdHRlcmllcykNCiAgICB7DQogICAgICBibG9jay5HZXRBY3Rpb25XaXRoTmFtZSgiT25PZmZfT24iKS5BcHBseShibG9jayk7DQogICAgICBibG9jay5HZXRBY3Rpb25XaXRoTmFtZSgiUmVjaGFyZ2UiKS5BcHBseShibG9jayk7IC8vU3dpdGNoIHJlY2hhcmdpbmcgY29udGludW91c2x5LCB0aGF0J3MgdGhlIGJlc3QgZm9yIGtlZXBpbmcgdGhlIHBvd2VyDQogICAgfQ0KICAgDQogICAgaWYoYmxvY2sgaXMgSU15QmVhY29uICYmIG1lc3NVcEJlYWNvbnMpDQogICAgew0KICAgICAgYmxvY2suR2V0QWN0aW9uV2l0aE5hbWUoIk9uT2ZmX09mZiIpLkFwcGx5KGJsb2NrKTsgLy9UdXJuIGJlYWNvbnMgb2ZmLCB3ZSBkb24ndCBuZWVkIGFueSBoZWxwDQogICAgfQ0KICAgDQogICAgaWYoYmxvY2sgaXMgSU15QnV0dG9uUGFuZWwgJiYgbWVzc1VwQnV0dG9uUGFuZWxzKQ0KICAgIHsNCiAgICAgIGlmKCgoSU15QnV0dG9uUGFuZWwpYmxvY2spLkFueW9uZUNhblVzZSkNCiAgICAgIHsNCiAgICAgICAgYmxvY2suR2V0QWN0aW9uV2l0aE5hbWUoIkFueW9uZUNhblVzZSIpLkFwcGx5KGJsb2NrKTsgLy9EbyBldmVyeXRoaW5nIHdlIGNhbg0KICAgICAgfQ0KICAgIH0NCiAgIA0KICAgIGlmKGJsb2NrIGlzIElNeUNhbWVyYUJsb2NrICYmIG1lc3NVcENhbWVyYXMpDQogICAgew0KICAgICAgYmxvY2suR2V0QWN0aW9uV2l0aE5hbWUoIk9uT2ZmX09uIikuQXBwbHkoYmxvY2spOw0KICAgICAgYmxvY2suR2V0QWN0aW9uV2l0aE5hbWUoIlZpZXciKS5BcHBseShibG9jayk7IC8vSSB3b25kZXIgd2hhdCB0aGUgaGVjayB3aWxsIGhhcHBlbiBoZXJlDQogICAgfQ0KICAgDQogICAgaWYoYmxvY2sgaXMgSU15U2hpcENvbnRyb2xsZXIgJiYgbWVzc1VwQ29ja3BpdHMpIC8vQWxsIGNvY2twaXRzIGFuZCByZW1vdGVzIC0ga2lsbCB0aGVtIGFsbA0KICAgIHsNCiAgICAgIHZhciBjb2NrcGl0ID0gYmxvY2sgYXMgSU15U2hpcENvbnRyb2xsZXI7DQogICAgICBpZihjb2NrcGl0LkNvbnRyb2xXaGVlbHMpDQogICAgICB7DQogICAgICAgIGNvY2twaXQuR2V0QWN0aW9uV2l0aE5hbWUoIkNvbnRyb2xXaGVlbHMiKS5BcHBseShjb2NrcGl0KTsNCiAgICAgIH0NCiAgICAgIGlmKCFjb2NrcGl0LkNvbnRyb2xUaHJ1c3RlcnMpDQogICAgICB7DQogICAgICAgIGNvY2twaXQuR2V0QWN0aW9uV2l0aE5hbWUoIkNvbnRyb2xUaHJ1c3RlcnMiKS5BcHBseShjb2NrcGl0KTsNCiAgICAgIH0NCiAgICAgIGlmKGNvY2twaXQuSGFuZEJyYWtlKQ0KICAgICAgew0KICAgICAgICBjb2NrcGl0LkdldEFjdGlvbldpdGhOYW1lKCJIYW5kQnJha2UiKS5BcHBseShjb2NrcGl0KTsNCiAgICAgIH0NCiAgICAgIGlmKGNvY2twaXQuRGFtcGVuZXJzT3ZlcnJpZGUpDQogICAgICB7DQogICAgICAgIGNvY2twaXQuR2V0QWN0aW9uV2l0aE5hbWUoIkRhbXBlbmVyc092ZXJyaWRlIikuQXBwbHkoY29ja3BpdCk7DQogICAgICB9DQogICAgfQ0KICAgDQogICAgaWYoYmxvY2sgaXMgSU15Q29sbGVjdG9yICYmIG1lc3NVcENvbGxlY3RvcnMpDQogICAgew0KICAgICAgYmxvY2suR2V0QWN0aW9uV2l0aE5hbWUoIk9uT2ZmX09mZiIpLkFwcGx5KGJsb2NrKTsgLy9EbyBub3QgYWNjZXB0IGFueSBzdXBwbGllcw0KICAgIH0NCiAgIA0KICAgIGlmKGJsb2NrIGlzIElNeVNoaXBDb25uZWN0b3IgJiYgbWVzc1VwQ29ubmVjdG9ycykNCiAgICB7DQogICAgICB2YXIgY29ubmVjdG9yID0gYmxvY2sgYXMgSU15U2hpcENvbm5lY3RvcjsNCiAgICAgIGNvbm5lY3Rvci5HZXRBY3Rpb25XaXRoTmFtZSgiT25PZmZfT24iKS5BcHBseShjb25uZWN0b3IpOw0KICAgICAgaWYoIWNvbm5lY3Rvci5UaHJvd091dCkNCiAgICAgIHsNCiAgICAgICAgY29ubmVjdG9yLkdldEFjdGlvbldpdGhOYW1lKCJUaHJvd091dCIpLkFwcGx5KGNvbm5lY3Rvcik7IC8vVGhyb3cgb3V0IGV2ZXJ5dGhpbmcNCiAgICAgIH0NCiAgICAgIGlmKCFjb25uZWN0b3IuQ29sbGVjdEFsbCkNCiAgICAgIHsNCiAgICAgICAgY29ubmVjdG9yLkdldEFjdGlvbldpdGhOYW1lKCJDb2xsZWN0QWxsIikuQXBwbHkoY29ubmVjdG9yKTsgLy9Gcm9tIGV2ZXJ5d2hlcmUNCiAgICAgIH0NCiAgICAgIGlmKGNvbm5lY3Rvci5Jc0xvY2tlZCkNCiAgICAgIHsNCiAgICAgICAgLy9jb25uZWN0b3IuR2V0QWN0aW9uV2l0aE5hbWUoIlN3aXRjaExvY2siKS5BcHBseShjb25uZWN0b3IpOyAvL1RvIG5vd2hlcmUNCiAgICAgIH0NCiAgICB9DQogICANCiAgICAvL0NvbnRyb2wgUGFuZWxzIGRvZXNuJ3QgaGF2ZSBhbnl0aGluZyB0aGF0IGNvdWxkIGJlIGhhbmRsZWQgcmlnaHQgbm93DQogICANCiAgICBpZihibG9jayBpcyBJTXlEb29yICYmIG1lc3NVcERvb3JzKQ0KICAgIHsNCiAgICAgIGJsb2NrLkdldEFjdGlvbldpdGhOYW1lKCJPcGVuX09mZiIpLkFwcGx5KGJsb2NrKTsgLy9UcmFwIGV2ZXJ5Ym9keQ0KICAgICAgaWYoISgoSU15RG9vcilibG9jaykuT3BlbikNCiAgICAgIHsNCiAgICAgICAgYmxvY2suR2V0QWN0aW9uV2l0aE5hbWUoIk9uT2ZmX09mZiIpLkFwcGx5KGJsb2NrKTsgLy9NYWtlIGRvb3JzIHVuYWJsZSB0byBvcGVuIGFzIHNvb24gYXMgdGhleSBjbG9zZWQNCiAgICAgIH0NCiAgICB9DQogICANCiAgICBpZihibG9jayBpcyBJTXlTaGlwRHJpbGwgJiYgbWVzc1VwRHJpbGxzKQ0KICAgIHsNCiAgICAgIGJsb2NrLkdldEFjdGlvbldpdGhOYW1lKCJPbk9mZl9PbiIpLkFwcGx5KGJsb2NrKTsgLy9XZSBjYW4gbmV2ZXIga25vdyB3aGF0IGlzIGluIGZyb250IG9mIHRob3NlIGJsb2Nrcw0KICAgIH0NCiAgIA0KICAgIGlmKGJsb2NrIGlzIElNeUxhcmdlVHVycmV0QmFzZSAmJiBtZXNzVXBUdXJyZXRzKSAvL0FsbCB0dXJyZXRzDQogICAgew0KICAgICAgYmxvY2suR2V0QWN0aW9uV2l0aE5hbWUoIk9uT2ZmX09mZiIpLkFwcGx5KGJsb2NrKTsgLy9XZS4gRG9uJ3QuIE5lZWQuIERlZmVuc2UuDQogICAgfQ0KICAgDQogICAgaWYoYmxvY2sgaXMgSU15R3Jhdml0eUdlbmVyYXRvckJhc2UgJiYgbWVzc1VwR3Jhdml0eSkNCiAgICB7DQogICAgICBibG9jay5HZXRBY3Rpb25XaXRoTmFtZSgiT25PZmZfT2ZmIikuQXBwbHkoYmxvY2spOyAvL1R1cm4gb2ZmIGdyYXZpdHksIGl0IG1ha2VzIGVzY2FwaW5nIHRoZSBzaGlwIGV2ZW4gbW9yZSBkaWZmaWN1bHQNCiAgICB9DQogICANCiAgICBpZihibG9jayBpcyBJTXlTaGlwR3JpbmRlciAmJiBtZXNzVXBHcmluZGVycykNCiAgICB7DQogICAgICBibG9jay5HZXRBY3Rpb25XaXRoTmFtZSgiT25PZmZfT24iKS5BcHBseShibG9jayk7IC8vQ2hhaW5zYXcgbG9sDQogICAgfQ0KICAgDQogICAgaWYoYmxvY2sgaXMgSU15R3lybyAmJiBtZXNzVXBHeXJvcykNCiAgICB7DQogICAgICB2YXIgZ3lybyA9IGJsb2NrIGFzIElNeUd5cm87DQogICAgICBneXJvLkdldEFjdGlvbldpdGhOYW1lKCJPbk9mZl9PbiIpLkFwcGx5KGd5cm8pOw0KICAgICAgaWYoIWd5cm8uR3lyb092ZXJyaWRlKQ0KICAgICAgew0KICAgICAgICBneXJvLkdldEFjdGlvbldpdGhOYW1lKCJPdmVycmlkZSIpLkFwcGx5KGd5cm8pOw0KICAgICAgfQ0KICAgICAgZ3lyby5HZXRBY3Rpb25XaXRoTmFtZSgiSW5jcmVhc2VQb3dlciIpLkFwcGx5KGd5cm8pOw0KICAgICAgaWYocm5kLk5leHREb3VibGUoKSA+IDAuNWYpIC8vT2theSwgbm93IG1lc3MgdGhlbSB1cA0KICAgICAgew0KICAgICAgICBneXJvLkdldEFjdGlvbldpdGhOYW1lKCJJbmNyZWFzZVlhdyIpLkFwcGx5KGd5cm8pOw0KICAgICAgfQ0KICAgICAgZWxzZQ0KICAgICAgew0KICAgICAgICBneXJvLkdldEFjdGlvbldpdGhOYW1lKCJEZWNyZWFzZVlhdyIpLkFwcGx5KGd5cm8pOw0KICAgICAgfQ0KICAgICAgaWYocm5kLk5leHREb3VibGUoKSA+IDAuNWYpDQogICAgICB7DQogICAgICAgIGd5cm8uR2V0QWN0aW9uV2l0aE5hbWUoIkluY3JlYXNlUGl0Y2giKS5BcHBseShneXJvKTsNCiAgICAgIH0NCiAgICAgIGVsc2UNCiAgICAgIHsNCiAgICAgICAgZ3lyby5HZXRBY3Rpb25XaXRoTmFtZSgiRGVjcmVhc2VQaXRjaCIpLkFwcGx5KGd5cm8pOw0KICAgICAgfQ0KICAgICAgaWYocm5kLk5leHREb3VibGUoKSA+IDAuNWYpDQogICAgICB7DQogICAgICAgIGd5cm8uR2V0QWN0aW9uV2l0aE5hbWUoIkluY3JlYXNlUm9sbCIpLkFwcGx5KGd5cm8pOw0KICAgICAgfQ0KICAgICAgZWxzZQ0KICAgICAgew0KICAgICAgICBneXJvLkdldEFjdGlvbldpdGhOYW1lKCJEZWNyZWFzZVJvbGwiKS5BcHBseShneXJvKTsNCiAgICAgIH0NCiAgICB9DQogICANCiAgICBpZihibG9jayBpcyBJTXlMaWdodGluZ0Jsb2NrICYmIG1lc3NVcExpZ2h0cykNCiAgICB7DQogICAgICBibG9jay5HZXRBY3Rpb25XaXRoTmFtZSgiT25PZmZfT2ZmIikuQXBwbHkoYmxvY2spOyAvL1R1cm4gb2ZmIHRoZSBsaWdodHMuLi4NCiAgICB9DQogICANCiAgICBpZihibG9jayBpcyBJTXlMYW5kaW5nR2VhciAmJiBtZXNzVXBMYW5kaW5nR2VhcnMpDQogICAgew0KICAgICAgYmxvY2suR2V0QWN0aW9uV2l0aE5hbWUoIk9uT2ZmX09uIikuQXBwbHkoYmxvY2spOw0KICAgICAgYmxvY2suR2V0QWN0aW9uV2l0aE5hbWUoIlVubG9jayIpLkFwcGx5KGJsb2NrKTsNCiAgICB9DQogICANCiAgICAvL0NhcmdvIGNvbnRhaW5lcnMgaGFzIG5vIGludGVyZmFjZQ0KICAgDQogICAgaWYoYmxvY2sgaXMgSU15UmVhY3RvciAmJiBtZXNzVXBSZWFjdG9ycykNCiAgICB7DQogICAgICBibG9jay5HZXRBY3Rpb25XaXRoTmFtZSgiT25PZmZfT24iKS5BcHBseShibG9jayk7IC8vUnVuIHRoZW0gYXMgbG9uZyBhcyB0aGVyZSBpcyBlbm91Z2ggdXJhbml1bQ0KICAgIH0NCiAgIA0KICAgIGlmKGJsb2NrIGlzIElNeU1lZGljYWxSb29tICYmIG1lc3NVcE1lZGljYWxSb29tcykNCiAgICB7DQogICAgICBibG9jay5HZXRBY3Rpb25XaXRoTmFtZSgiT25PZmZfT2ZmIikuQXBwbHkoYmxvY2spOyAvL0Rvbid0IHJlc3Bhd24sIHRoYXQncyBub3QgZnVubnkNCiAgICB9DQogICANCiAgICBpZihibG9jayBpcyBJTXlTaGlwTWVyZ2VCbG9jayAmJiBtZXNzVXBNZXJnZUJsb2NrcykNCiAgICB7DQogICAgICBibG9jay5HZXRBY3Rpb25XaXRoTmFtZSgiT25PZmZfT2ZmIikuQXBwbHkoYmxvY2spOyAvL0lmIGl0IHdhcyBhIG1vZHVsYXIgc2hpcC4uLiB3ZWxsLCBpdCB3YXMNCiAgICB9DQogICANCiAgICBpZihibG9jayBpcyBJTXlPcmVEZXRlY3RvciAmJiBtZXNzVXBPcmVEZXRlY3RvcnMpDQogICAgew0KICAgICAgYmxvY2suR2V0QWN0aW9uV2l0aE5hbWUoIk9uT2ZmX09mZiIpLkFwcGx5KGJsb2NrKTsgLy9KdXN0IHR1cm4gdGhlbSBvZmYsIGN1eiB3aHkgbm90PyBJZiBpdCBtYWtlcyBtZXNzIGl0J3Mgd2VsY29tZS4uLg0KICAgIH0NCiAgIA0KICAgIGlmKGJsb2NrIGlzIElNeVBpc3RvbkJhc2UgJiYgbWVzc1VwUGlzdG9ucykNCiAgICB7DQogICAgICBibG9jay5HZXRBY3Rpb25XaXRoTmFtZSgiT25PZmZfT24iKS5BcHBseShibG9jayk7DQogICAgICBpZigoKElNeVBpc3RvbkJhc2UpYmxvY2spLlZlbG9jaXR5PDApDQogICAgICB7DQogICAgICAgIGJsb2NrLkdldEFjdGlvbldpdGhOYW1lKCJSZXZlcnNlIikuQXBwbHkoYmxvY2spOyAvL1JldmVyc2UgdGhlbSBpZiB0aGV5J3JlIG9wZW4NCiAgICAgIH0NCiAgICAgIGJsb2NrLkdldEFjdGlvbldpdGhOYW1lKCJJbmNyZWFzZVZlbG9jaXR5IikuQXBwbHkoYmxvY2spOyAvL0Zhc3RlciBpcyBiZXR0ZXINCiAgICAgIGJsb2NrLkdldEFjdGlvbldpdGhOYW1lKCJJbmNyZWFzZVVwcGVyTGltaXQiKS5BcHBseShibG9jayk7IC8vQnJlYWsgZXZlcnl0aGluZyBvciBhdCBsZWFzdCByZW1haW4gY2xvc2VkDQogICAgfQ0KICAgDQogICAgLy9Eb24ndCBkbyBhbnl0aGluZyB3aXRoIHRpbWVycyBvciBwcm9ncmFtbWFibGUgYmxvY2tzLiBUaGV5IGNhbiBlaXRoZXIgYmUgb3VycyBvciBjb250YWluIGFudGl2aXJ1cyBzb2Z0d2FyZS4gSGFuZGxlIHRoZW0gYXMgc29vbiBhcyB3ZSBnZXQgYSBiZXR0ZXIgQVBJLg0KICAgDQogICAgaWYoKGJsb2NrIGlzIElNeVNtYWxsTWlzc2lsZUxhdW5jaGVyIHx8IGJsb2NrIGlzIElNeVNtYWxsTWlzc2lsZUxhdW5jaGVyUmVsb2FkKSAmJiBtZXNzVXBNaXNzaWxlTGF1bmNoZXJzKQ0KICAgIHsNCiAgICAgIGJsb2NrLkdldEFjdGlvbldpdGhOYW1lKCJPbk9mZl9PZmYiKS5BcHBseShibG9jayk7IC8vT2ZmZW5zZSBzaG91bGQgYWxzbyBiZSB0dXJuZWQgb2ZmIGxpa2UgZGVmZW5zZQ0KICAgIH0NCiAgIA0KICAgIGlmKGJsb2NrIGlzIElNeU1vdG9yU3RhdG9yICYmIG1lc3NVcFJvdG9ycykNCiAgICB7DQogICAgICBibG9jay5HZXRBY3Rpb25XaXRoTmFtZSgiT25PZmZfT24iKS5BcHBseShibG9jayk7DQogICAgICB2YXIgcm90b3IgPSBibG9jayBhcyBJTXlNb3RvclN0YXRvcjsNCiAgICAgIGlmKHJvdG9yLlZlbG9jaXR5PDApDQogICAgICB7DQogICAgICAgIHJvdG9yLkdldEFjdGlvbldpdGhOYW1lKCJSZXZlcnNlIikuQXBwbHkocm90b3IpOyAvL1JldmVyc2UgaWYgc3BlZWQgaXMgbmVnYXRpdmUNCiAgICAgIH0NCiAgICAgDQogICAgICAvL1NwZWVkIGl0IHVwDQogICAgICByb3Rvci5HZXRBY3Rpb25XaXRoTmFtZSgiSW5jcmVhc2VUb3JxdWUiKS5BcHBseShyb3Rvcik7DQogICAgICByb3Rvci5HZXRBY3Rpb25XaXRoTmFtZSgiRGVjcmVhc2VCcmFraW5nVG9ycXVlIikuQXBwbHkocm90b3IpOw0KICAgICAgcm90b3IuR2V0QWN0aW9uV2l0aE5hbWUoIkluY3JlYXNlVmVsb2NpdHkiKS5BcHBseShyb3Rvcik7DQogICAgICByb3Rvci5HZXRBY3Rpb25XaXRoTmFtZSgiSW5jcmVhc2VVcHBlckxpbWl0IikuQXBwbHkocm90b3IpOw0KICAgICAgcm90b3IuR2V0QWN0aW9uV2l0aE5hbWUoIkRlY3JlYXNlTG93ZXJMaW1pdCIpLkFwcGx5KHJvdG9yKTsNCiAgICAgDQogICAgICBpZihyb3Rvci5WZWxvY2l0eT4yNSkNCiAgICAgIHsNCiAgICAgICAgaWYocm9sbERldGFjaFRpbWVyKQ0KICAgICAgICB7DQogICAgICAgICAgZGV0YWNoVGltZXIrKzsNCiAgICAgICAgICByb2xsRGV0YWNoVGltZXIgPSBmYWxzZTsNCiAgICAgICAgfQ0KICAgICAgICBpZihkZXRhY2hUaW1lcj5kZXRhY2hEZWxheSkNCiAgICAgICAgew0KICAgICAgICAgIHJvdG9yLkdldEFjdGlvbldpdGhOYW1lKCJEZXRhY2giKS5BcHBseShyb3Rvcik7IC8vRGV0YWNoIGFzIHNvb24gYXMgaXQncyBmYXN0IGVub3VnaA0KICAgICAgICB9DQogICAgICB9DQogICAgfQ0KICAgDQogICAgaWYoYmxvY2sgaXMgSU15U2Vuc29yQmxvY2sgJiYgbWVzc1VwU2Vuc29ycykNCiAgICB7DQogICAgICBibG9jay5HZXRBY3Rpb25XaXRoTmFtZSgiT25PZmZfT2ZmIikuQXBwbHkoYmxvY2spOyAvL1dlIGRvbid0IGtub3cgd2hhdCBpdCBkb2VzLCBiZXR0ZXIganVzdCB0dXJuIGl0IG9mZg0KICAgIH0NCiAgIA0KICAgIGlmKGJsb2NrIGlzIElNeVNvdW5kQmxvY2sgJiYgbWVzc1VwU291bmRCbG9ja3MpIC8vV2FubmEgcGxheSBhIGdhbWU/DQogICAgew0KICAgICAgYmxvY2suR2V0QWN0aW9uV2l0aE5hbWUoIk9uT2ZmX09uIikuQXBwbHkoYmxvY2spOw0KICAgICAgYmxvY2suR2V0QWN0aW9uV2l0aE5hbWUoIkluY3JlYXNlVm9sdW1lU2xpZGVyIikuQXBwbHkoYmxvY2spOw0KICAgICAgYmxvY2suR2V0QWN0aW9uV2l0aE5hbWUoIkluY3JlYXNlUmFuZ2VTbGlkZXIiKS5BcHBseShibG9jayk7DQogICAgICBibG9jay5HZXRBY3Rpb25XaXRoTmFtZSgiSW5jcmVhc2VMb29wYWJsZVNsaWRlciIpLkFwcGx5KGJsb2NrKTsNCiAgICAgIGJsb2NrLkdldEFjdGlvbldpdGhOYW1lKCJQbGF5U291bmQiKS5BcHBseShibG9jayk7DQogICAgfQ0KICAgDQogICAgaWYoYmxvY2sgaXMgSU15V2FyaGVhZCAmJiBleHBsb2RlRXZlcnl0aGluZykgLy9JbmNvbWluZyBmdW5ueSBzdHVmZg0KICAgIHsNCiAgICAgIGJsb2NrLkdldEFjdGlvbldpdGhOYW1lKCJTYWZldHkiKS5BcHBseShibG9jayk7IC8vSWYgaXQgdHVybnMgb24gc2FmZXR5IGZvciB0aGUgZmlyc3QgdHJ5IGl0IHdpbGwgdHVybiBpdCBvZmYgc2Vjb25kIGFuZCBldmVyeXRoaW5nIHdpbGwgZXhwbG9kZSBpbiBvbmUgc2VjDQogICAgICBibG9jay5HZXRBY3Rpb25XaXRoTmFtZSgiRGV0b25hdGUiKS5BcHBseShibG9jayk7DQogICAgfQ0KICAgDQogICAgaWYoYmxvY2sgaXMgSU15U2hpcFdlbGRlciAmJiBtZXNzVXBXZWxkZXJzKQ0KICAgIHsNCiAgICAgIGJsb2NrLkdldEFjdGlvbldpdGhOYW1lKCJPbk9mZl9PZmYiKS5BcHBseShibG9jayk7IC8vQmV3YXJlLCB0aGVyZSBjYW4gYmUgc2VsZi1yZXBhaXJpbmcgc3R1ZmYNCiAgICB9DQogICANCiAgICBpZihibG9jayBpcyBJTXlNb3RvclN1c3BlbnNpb24gJiYgbWVzc1VwV2hlZWxzKSAvL1R1cm4gb2ZmIHRoZSB3aGVlbHMNCiAgICB7DQogICAgICB2YXIgd2hlZWwgPSBibG9jayBhcyBJTXlNb3RvclN1c3BlbnNpb247DQogICAgICB3aGVlbC5HZXRBY3Rpb25XaXRoTmFtZSgiT25PZmZfT2ZmIikuQXBwbHkod2hlZWwpOw0KICAgICAgaWYod2hlZWwuU3RlZXJpbmcpDQogICAgICB7DQogICAgICAgIHdoZWVsLkdldEFjdGlvbldpdGhOYW1lKCJTdGVlcmluZyIpLkFwcGx5KHdoZWVsKTsNCiAgICAgIH0NCiAgICAgIGlmKHdoZWVsLlByb3B1bHNpb24pDQogICAgICB7DQogICAgICAgIHdoZWVsLkdldEFjdGlvbldpdGhOYW1lKCJQcm9wdWxzaW9uIikuQXBwbHkod2hlZWwpOw0KICAgICAgfQ0KICAgICAgd2hlZWwuR2V0QWN0aW9uV2l0aE5hbWUoIkRlY3JlYXNlRGFtcGluZyIpLkFwcGx5KHdoZWVsKTsNCiAgICAgIHdoZWVsLkdldEFjdGlvbldpdGhOYW1lKCJEZWNyZWFzZVN0cmVuZ3RoIikuQXBwbHkod2hlZWwpOw0KICAgICAgd2hlZWwuR2V0QWN0aW9uV2l0aE5hbWUoIkRlY3JlYXNlRnJpY3Rpb24iKS5BcHBseSh3aGVlbCk7DQogICAgICB3aGVlbC5HZXRBY3Rpb25XaXRoTmFtZSgiRGVjcmVhc2VQb3dlciIpLkFwcGx5KHdoZWVsKTsNCiAgICB9DQogICANCiAgICAvL090aGVyIHRoaW5ncw0KICAgDQogICAgaWYoYmxvY2sgaXMgSU15UHJvZHVjdGlvbkJsb2NrICYmIHJlbmFtZUV2ZXJ5dGhpbmcpIC8vV2UgbmVlZCBFVkVSWVRISU5HIHRvIHVzZSBjb252ZXlvciBzeXN0ZW0NCiAgICB7DQogICAgICBibG9jay5HZXRBY3Rpb25XaXRoTmFtZSgiT25PZmZfT24iKS5BcHBseShibG9jayk7DQogICAgICBpZighKChJTXlQcm9kdWN0aW9uQmxvY2spYmxvY2spLlVzZUNvbnZleW9yU3lzdGVtKQ0KICAgICAgew0KICAgICAgICBibG9jay5HZXRBY3Rpb25XaXRoTmFtZSgiVXNlQ29udmV5b3IiKS5BcHBseShibG9jayk7DQogICAgICB9DQogICAgfQ0KICAgDQogICAgaWYocmVuYW1lRXZlcnl0aGluZykNCiAgICB7DQogICAgICBibG9jay5TZXRDdXN0b21OYW1lKCIiKTsgLy9UaGUgc2Vjb25kIGV2aWxlc3QgdGhpbmcgSSBjYW4gaW1hZ2luZS4gVGhlIGZpcnN0IGlzIEMjLi4uDQogICAgfQ0KICAgDQogICAgaWYoYmxvY2sgaXMgSU15VGhydXN0ICYmIG1lc3NVcFRocnVzdGVycykNCiAgICB7DQogICAgICBibG9jay5HZXRBY3Rpb25XaXRoTmFtZSgiT25PZmZfT24iKS5BcHBseShibG9jayk7DQogICAgICBibG9jay5HZXRBY3Rpb25XaXRoTmFtZSgiSW5jcmVhc2VPdmVycmlkZSIpLkFwcGx5KGJsb2NrKTsNCiAgICB9DQogIH0=";
public static string Base64Decode(string base64EncodedData) {
  var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
  return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
}
List<IMyTerminalBlock> prog = new List<IMyTerminalBlock>();
void main(){
  prog.Clear();
  GridTerminalSystem.GetBlocksOfType<IMyFunctionalBlock>(prog);
  for(int i=0; i < prog.Count; i++){
    var block = prog[i];
    if(((IMyProgrammableBlock)block).IsRunning) break; //prevent infecting ourselves
    else {
      string ourPayload = Base64Decode(payload);
    // i hope this will be possible, so much!
    //writes payload to prog block

    //block.GetActionWithName("Write"(ourPayload)).Apply(block);

    //This is possible
    block.GetActionWithName("Run").Apply(block);
    }
  }
}