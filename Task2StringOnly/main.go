package main

import (
	"fmt"
)

func main() {
	str := "a=2,t=5,c=3"

	var letters, digits string

	for _, c := range str {
		if c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z' {
			letters += string(c)
		} else if c >= '0' && c <= '9' {
			digits = string(c) + digits
		}
	}

	result := letters + digits
	fmt.Println(result)
}
