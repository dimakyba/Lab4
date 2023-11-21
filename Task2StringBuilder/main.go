package main

import (
	"fmt"
	"strings"
)

func main() {
	str := "a=2,t=5,c=3"

	var letters strings.Builder
	var digits strings.Builder

	for _, c := range str {
		if c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z' {
			letters.WriteRune(c)
		} else if c >= '0' && c <= '9' {
			Insert(&digits, 0, fmt.Sprintf("%c", c))
		}
	}

	result := letters.String() + digits.String()
	fmt.Println(result)
}

func Insert(b *strings.Builder, index int, str string) {
	s := b.String()
	b.Reset()
	b.WriteString(s[:index] + str + s[index:])
}
