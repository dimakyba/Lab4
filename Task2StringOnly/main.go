package main

import (
	"fmt"
)

func main() {
	str := "a=2,t=5,c=3"

	var result string

	for _, c := range str {
		if c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z' {
			result += string(c)
		}
	}
	strLastIndex := len(result)
	for _, c := range str {
		if c >= '0' && c <= '9' {
			result = Insert(result, strLastIndex, fmt.Sprintf("%c", c))
		}
	}
	fmt.Println(result)
}

// result := result

func Insert(s string, index int, str string) string {
	if index < 0 || index > len(s) {
		return s
	}
	return s[:index] + str + s[index:]
}
